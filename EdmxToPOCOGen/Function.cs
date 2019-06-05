using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EdmxToPOCOGen
{
    public class Function
    {
        static char[] splitwithdot = new char[1] { '.' };
        public string Name { get; set; }
        public string EdmxReturnType { get; set; }
        public string ReturnType
        {
            get
            {
                if (string.IsNullOrWhiteSpace(EdmxReturnType))
                {
                    return string.Empty;
                }
                var retVal = EdmxReturnType;
                var pattren = @"^Collection\(?(.+)\)$";
                Regex expression = new Regex(pattren, RegexOptions.IgnoreCase);
                var mat = expression.Match(retVal);
                if (mat.Success)
                {
                    retVal = mat.Groups[mat.Groups.Count - 1].Value.Split(splitwithdot).Last();
                }
                return retVal;
            }
        }
        public string ClassReturn
        {
            get
            {
                var retVal = EdmxReturnType;
                if (string.IsNullOrEmpty(retVal))
                {
                    return "int";
                }
                return string.Format("ObjectResult<{0}>", ReturnType);
            }
        }
        public List<Parameter> Parameters { get; set; }

        public string GetAssingedParams()
        {
            StringBuilder assigmParam = new StringBuilder();
            foreach (var param in this.Parameters)
            {
                if (param.Mode == "InOut" || param.Mode == "Out")
                {
                    assigmParam.AppendLine(string.Format("           var {0}Parameter = new SqlParameter(\"{1}\", SqlDbType.{2}{3});", param.FunctionParamName, param.Name, param.SqlTypeEnum.ToString(), param.ClrType == "String" ? ", 500" : ""));
                    assigmParam.AppendLine(string.Format("               {0}Parameter.Direction = System.Data.ParameterDirection.Output;", param.FunctionParamName));
                    assigmParam.AppendLine(string.Format("               {0}Parameter.Value = {0} != null ? {0}.Value : null;", param.FunctionParamName));
                }
                else
                {
                    if (param.SqlTypeEnum == SqlDbType.VarChar)
                    {
                        assigmParam.AppendLine(string.Format("           var {0}Parameter = new SqlParameter(\"{1}\", SqlDbType.{2}, 500);", param.FunctionParamName, param.Name, param.SqlTypeEnum.ToString()));
                        assigmParam.AppendLine(string.Format("           if (string.IsNullOrWhiteSpace({0}))", param.FunctionParamName));
                        assigmParam.AppendLine("           {");
                        assigmParam.AppendLine(string.Format("               {0}Parameter.IsNullable = true;", param.FunctionParamName));
                        assigmParam.AppendLine(string.Format("               {0}Parameter.Value = DBNull.Value;", param.FunctionParamName));
                        assigmParam.AppendLine("           }");
                        assigmParam.AppendLine("           else");
                        assigmParam.AppendLine("           {");
                        assigmParam.AppendLine(string.Format("               {0}Parameter.Value = {0};", param.FunctionParamName));
                        assigmParam.AppendLine("           }");
                    }
                    else
                    {
                        assigmParam.AppendLine(string.Format("            var {0}Parameter = {0}{1} ?", param.FunctionParamName, param.Nullable ? ".HasValue" : " != null"));
                        assigmParam.AppendLine(string.Format("                new SqlParameter(\"{0}\", {1}) :", param.Name, param.FunctionParamName));
                        assigmParam.AppendLine(string.Format("                new SqlParameter(\"{0}\", SqlDbType.{1});", param.Name, param.SqlTypeEnum.ToString()));
                    }
                }
                assigmParam.AppendLine("");
            }
            return assigmParam.ToString();
        }

        public string GetReturnStatement()
        {
            StringBuilder returnStatement = new StringBuilder();
            var parmBuild = string.Join(", ", this.Parameters.Select(x => { return (x.Mode == "InOut" || x.Mode == "Out") ? (x.SqlParamName + " OUT") : x.SqlParamName; }));
            var actualParams = string.Empty;
            if (string.IsNullOrWhiteSpace(parmBuild))
            {
                actualParams = "\"";
            }
            else
            {
                actualParams = string.Format(" {0}\", ", parmBuild);
            }
            returnStatement.AppendLine(string.Format("            var retVal = ((IObjectContextAdapter)this).ObjectContext.{0}(\"{1}{2}{3});",
                (string.IsNullOrEmpty(this.ReturnType) ? "ExecuteStoreCommand" : string.Format("ExecuteStoreQuery<{0}>", this.ReturnType)), this.Name, actualParams,
                string.Join(", ", this.Parameters.Select(x => string.Format("{0}Parameter", x.FunctionParamName)))));
            returnStatement.AppendLine("");
            foreach (var outParam in this.Parameters.Where(x => x.Mode == "InOut" || x.Mode == "Out"))
            {
                returnStatement.AppendLine(string.Format("            {0}.Value = {0}Parameter.Value;", outParam.FunctionParamName));
            }
            returnStatement.AppendLine("");
            returnStatement.AppendLine("            return retVal;");
            return returnStatement.ToString();
        }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string Mode { get; set; }
        public string ClrType { get; set; }
        public string SqlType { get; set; }
        public bool Nullable { get; set; }
        public string FunctionParamName
        {
            get
            {
                return Char.ToLowerInvariant(Name[0]) + Name.Substring(1);
            }
        }

        public string SqlParamName
        {
            get
            {
                return "@" + Name;
            }
        }

        public SqlDbType SqlTypeEnum
        {
            get
            {
                var sqlDbType = (SqlDbType)Enum.Parse(typeof(SqlDbType), SqlType, true);
                return sqlDbType;
            }
        }

        public string ParamType
        {
            get
            {
                if (Mode == "InOut" || Mode == "Out")
                {
                    return string.Format("ObjectParameter {0}", FunctionParamName);
                }
                var paramType = "object";
                this.Nullable = false;

                if (SqlTypeEnum == SqlDbType.BigInt || SqlTypeEnum == SqlDbType.Int)
                {
                    this.Nullable = true;
                    paramType = string.Format("Nullable<{0}>", ClrType);
                }
                else if (SqlTypeEnum == SqlDbType.VarChar)
                {
                    paramType = "string";
                }

                return string.Format("{0} {1}", paramType, FunctionParamName);
            }
        }
    }

}
