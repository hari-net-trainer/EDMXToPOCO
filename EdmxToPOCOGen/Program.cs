﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace EdmxToPOCOGen
{
    class Program
    {
        static XElement edmxXmlElm;
        static string fileClassName = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to POCO(Plain Old CLR Object) genarator from EDMX!");
            Console.WriteLine("Did you add any new object(Only StoreProc) added to the EDMX?");
            Console.WriteLine("If Yes... Press Enter Else Press any key to exit.");
            var userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Prosessing Please wait....");
                Console.WriteLine("Fecching .edmx file within this solution...");
                foreach (var edmxFile in findEDMXFile())
                {
                    edmxXmlElm = XElement.Load(edmxFile);
                    StringBuilder autoGenPOCO = new StringBuilder();
                    autoGenPOCO = AutoGenCodeContext(autoGenPOCO);
                    Console.WriteLine(SaveFile(fileClassName, autoGenPOCO.ToString()));
                }
            }

            Console.ReadLine();
        }

        static string SaveFile(string fileName, string fileConten)
        {
            var parentFolder = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"../../../"));
            var filePath = Path.Combine(parentFolder, "Output");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = Path.Combine(filePath, fileName + ".Context.cs");
            using (StreamWriter swriter = new StreamWriter(filePath, false))
            {
                swriter.Write(fileConten);
            }

            return filePath;
        }

        static List<string> findEDMXFile()
        {
            var files = new List<string>();
            var parentFolder = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"../../../"));
            files = Directory.GetFiles(parentFolder, "*.edmx", SearchOption.AllDirectories).ToList();
            if (files.Any() == false)
            {
                Console.WriteLine("Please provide the edmx file path:");
                files.Add(Console.ReadLine());
            }

            return files;
        }

        static StringBuilder AutoGenCodeContext(StringBuilder autoGenPOCO)
        {
            XNamespace edmx = edmxXmlElm.Name.Namespace;
            string nameSpace = GetAttributeValue(edmx, "Schema", "Namespace", "ConceptualModels");
            fileClassName = GetAttributeValue(edmx, "EntityContainer", "Name", "ConceptualModels");
            var spLst = GetStoreProcs(edmx, "ConceptualModels");

            autoGenPOCO.AppendLine("//------------------------------------------------------------------------------");
            autoGenPOCO.AppendLine("// <auto-generated>");
            autoGenPOCO.AppendLine("//     This code was generated from a Reverse POCO Gen tool.");
            autoGenPOCO.AppendLine("//");
            autoGenPOCO.AppendLine("//     Manual changes to this file may cause unexpected behavior in your application.");
            autoGenPOCO.AppendLine("//     Manual changes to this file will be overwritten if the code is regenerated.");
            autoGenPOCO.AppendLine("// </auto-generated>");
            autoGenPOCO.AppendLine("//------------------------------------------------------------------------------");
            autoGenPOCO.AppendLine(string.Format("namespace {0}", nameSpace));
            autoGenPOCO.AppendLine("{");
            autoGenPOCO.AppendLine("    using System;");
            autoGenPOCO.AppendLine("    using System.Data.Entity;");
            autoGenPOCO.AppendLine("    using System.Data.Entity.Infrastructure;");
            autoGenPOCO.AppendLine("    using System.Data.Entity.Core.Objects;");
            autoGenPOCO.AppendLine("    using System.Linq;");
            autoGenPOCO.AppendLine("");
            autoGenPOCO.AppendLine(string.Format("    public partial class {0} : DbContext", fileClassName));
            autoGenPOCO.AppendLine("    {");
            autoGenPOCO.AppendLine(string.Format("        public {0}()", fileClassName));
            autoGenPOCO.AppendLine(string.Format("            : base(\"name={0}\")", fileClassName));
            autoGenPOCO.AppendLine("        {");
            autoGenPOCO.AppendLine("        }");
            autoGenPOCO.AppendLine("");
            autoGenPOCO.AppendLine("        protected override void OnModelCreating(DbModelBuilder modelBuilder)");
            autoGenPOCO.AppendLine("        {");
            autoGenPOCO.AppendLine("            throw new UnintentionalCodeFirstException();");
            autoGenPOCO.AppendLine("        }");
            autoGenPOCO.AppendLine("");

            foreach (var sp in spLst)
            {
                autoGenPOCO.AppendLine(string.Format("        public virtual {0} {1}({2})", sp.ClassReturn, sp.Name, string.Join(", ", sp.Parameters.Select(x => x.ParamType))));
                autoGenPOCO.AppendLine("        {");
                autoGenPOCO.AppendLine("");
                autoGenPOCO.AppendLine(sp.GetAssingedParams());
                autoGenPOCO.AppendLine(sp.GetReturnStatement());
                autoGenPOCO.AppendLine("        }");
            }
            autoGenPOCO.AppendLine("    }");
            autoGenPOCO.AppendLine("}");

            return autoGenPOCO;
        }

        static string GetAttributeValue(XNamespace edmxNS, string elmName, string attrName, string parantElm = null)
        {
            var retStr = string.Empty;
            var root = edmxXmlElm;
            if (!string.IsNullOrEmpty(parantElm))
            {
                root = edmxXmlElm.Descendants(edmxNS + parantElm).First();
            }

            retStr = root.Descendants().FirstOrDefault(x => x.Name.LocalName == elmName).Attribute(attrName).Value;

            return retStr;
        }

        static XElement GetElementByAttribute(XNamespace edmxNS, string elmName, string attrName, string attrValue, string parantElm = null)
        {
            var root = edmxXmlElm;
            if (!string.IsNullOrEmpty(parantElm))
            {
                root = edmxXmlElm.Descendants(edmxNS + parantElm).First();
            }

            var retElm = root.Descendants().Where(x => x.Name.LocalName == elmName);
            var temp = retElm.Where(x => x.Attribute(attrName) != null && x.Attribute(attrName).Value == attrValue).FirstOrDefault();
            return temp;
        }

        static List<Function> GetStoreProcs(XNamespace edmxNS, string elmName)
        {
            var spLst = new List<Function>();

            var root = edmxXmlElm.Descendants(edmxNS + elmName).First();
            foreach (var elm in root.Descendants())
            {
                if (elm.Name.LocalName == "FunctionImport")
                {
                    var func = new Function();
                    foreach (var attr in elm.Attributes())
                    {
                        if (attr.Name.LocalName == "Name")
                        {
                            func.Name = attr.Value;
                        }
                        else if (attr.Name.LocalName == "ReturnType")
                        {
                            func.EdmxReturnType = attr.Value;
                        }
                    }
                    func.Parameters = new List<Parameter>();
                    foreach (var param in elm.Descendants())
                    {
                        if (param.Name.LocalName == "Parameter")
                        {
                            var parmObj = new Parameter();
                            foreach (var parAttr in param.Attributes())
                            {
                                if (parAttr.Name.LocalName == "Name")
                                {
                                    parmObj.Name = parAttr.Value;
                                }
                                else if (parAttr.Name.LocalName == "Mode")
                                {
                                    parmObj.Mode = parAttr.Value;
                                }
                                else if (parAttr.Name.LocalName == "Type")
                                {
                                    parmObj.ClrType = parAttr.Value;
                                }
                            }
                            var sqlTyp = GetElementByAttribute(edmxNS, "Parameter", "Name", parmObj.Name, "StorageModels");
                            if (sqlTyp != null)
                            {
                                parmObj.SqlType = sqlTyp.Attribute("Type").Value;
                                parmObj.SqlType = parmObj.SqlType.ToLowerInvariant().Replace("(max)", string.Empty);
                            }
                            else
                            {
                                var clrType = (DbType)Enum.Parse(typeof(DbType), parmObj.ClrType, true);
                                var t = clrType.ToSqlDbType();
                                parmObj.SqlType = t.ToString();
                            }

                            func.Parameters.Add(parmObj);
                        }
                    }
                    spLst.Add(func);
                }
            }

            return spLst;
        }

    }
}
