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
    public static class SqlMapper
    {
        private static readonly Dictionary<Type, DbType> TypeToDbType
            = new Dictionary<Type, DbType>
              {
                  {typeof (byte), DbType.Byte},
                  {typeof (sbyte), DbType.SByte},
                  {typeof (short), DbType.Int16},
                  {typeof (ushort), DbType.UInt16},
                  {typeof (int), DbType.Int32},
                  {typeof (uint), DbType.UInt32},
                  {typeof (long), DbType.Int64},
                  {typeof (ulong), DbType.UInt64},
                  {typeof (float), DbType.Single},
                  {typeof (double), DbType.Double},
                  {typeof (decimal), DbType.Decimal},
                  {typeof (bool), DbType.Boolean},
                  {typeof (string), DbType.String},
                  {typeof (char), DbType.StringFixedLength},
                  {typeof (Guid), DbType.Guid},
                  {typeof (DateTime), DbType.DateTime},
                  {typeof (DateTimeOffset), DbType.DateTimeOffset},
                  {typeof (byte[]), DbType.Binary},
                  {typeof (byte?), DbType.Byte},
                  {typeof (sbyte?), DbType.SByte},
                  {typeof (short?), DbType.Int16},
                  {typeof (ushort?), DbType.UInt16},
                  {typeof (int?), DbType.Int32},
                  {typeof (uint?), DbType.UInt32},
                  {typeof (long?), DbType.Int64},
                  {typeof (ulong?), DbType.UInt64},
                  {typeof (float?), DbType.Single},
                  {typeof (double?), DbType.Double},
                  {typeof (decimal?), DbType.Decimal},
                  {typeof (bool?), DbType.Boolean},
                  {typeof (char?), DbType.StringFixedLength},
                  {typeof (Guid?), DbType.Guid},
                  {typeof (DateTime?), DbType.DateTime},
                  {typeof (DateTimeOffset?), DbType.DateTimeOffset}
              };

        private static readonly Dictionary<SqlDbType, Type> SqlDbTypeToType
            = new Dictionary<SqlDbType, Type>
              {
                  {SqlDbType.BigInt, typeof (long)},
                  {SqlDbType.Binary, typeof (byte[])},
                  {SqlDbType.Image, typeof (byte[])},
                  {SqlDbType.Timestamp, typeof (byte[])},
                  {SqlDbType.VarBinary, typeof (byte[])},
                  {SqlDbType.Bit, typeof (bool)},
                  {SqlDbType.Char, typeof (string)},
                  {SqlDbType.NChar, typeof (string)},
                  {SqlDbType.NText, typeof (string)},
                  {SqlDbType.NVarChar, typeof (string)},
                  {SqlDbType.Text, typeof (string)},
                  {SqlDbType.VarChar, typeof (string)},
                  {SqlDbType.Xml, typeof (string)},
                  {SqlDbType.DateTime, typeof (DateTime)},
                  {SqlDbType.SmallDateTime, typeof (DateTime)},
                  {SqlDbType.Date, typeof (DateTime)},
                  {SqlDbType.Time, typeof (DateTime)},
                  {SqlDbType.DateTime2, typeof (DateTime)},
                  {SqlDbType.Decimal, typeof (decimal)},
                  {SqlDbType.Money, typeof (decimal)},
                  {SqlDbType.SmallMoney, typeof (decimal)},
                  {SqlDbType.Float, typeof (double)},
                  {SqlDbType.Int, typeof (int)},
                  {SqlDbType.Real, typeof (float)},
                  {SqlDbType.UniqueIdentifier, typeof (Guid)},
                  {SqlDbType.SmallInt, typeof (short)},
                  {SqlDbType.TinyInt, typeof (byte)},
                  {SqlDbType.Variant, typeof (object)},
                  {SqlDbType.Udt, typeof (object)},
                  {SqlDbType.Structured, typeof (DataTable)},
                  {SqlDbType.DateTimeOffset, typeof (DateTimeOffset)}
              };

        private static readonly Dictionary<SqlDbType, DbType> SqlDbTypeToDBType
            = new Dictionary<SqlDbType, DbType>
              {
                    {SqlDbType.BigInt,DbType.Int64},
                    {SqlDbType.VarBinary,DbType.Binary},
                    {SqlDbType.Bit,DbType.Boolean},
                    {SqlDbType.Char,DbType.StringFixedLength},
                    {SqlDbType.Date,DbType.Date},
                    {SqlDbType.DateTime,DbType.DateTime},
                    {SqlDbType.DateTime2,DbType.DateTime2},
                    {SqlDbType.DateTimeOffset,DbType.DateTimeOffset},
                    {SqlDbType.Decimal,DbType.Decimal},
                    {SqlDbType.Float,DbType.Double},
                    {SqlDbType.Binary,DbType.Binary},
                    {SqlDbType.Int,DbType.Int32},
                    {SqlDbType.Money,DbType.Decimal},
                    {SqlDbType.NChar,DbType.StringFixedLength},
                    {SqlDbType.VarChar,DbType.String},
                    {SqlDbType.NVarChar,DbType.String},
                    {SqlDbType.NText,DbType.String},
                    {SqlDbType.Real,DbType.Single},
                    {SqlDbType.Timestamp,DbType.Binary},
                    {SqlDbType.SmallInt,DbType.Int16},
                    {SqlDbType.SmallMoney,DbType.Decimal},
                    {SqlDbType.Variant,DbType.Object},
                    {SqlDbType.Text,DbType.String},
                    {SqlDbType.Time,DbType.Time},
                    {SqlDbType.TinyInt,DbType.Byte},
                    {SqlDbType.UniqueIdentifier,DbType.Guid},
                    {SqlDbType.Xml,DbType.Xml}
              };

        private static readonly Dictionary<SqlDbType, Type> SqlDbTypeToNullableType
            = new Dictionary<SqlDbType, Type>
              {
                  {SqlDbType.BigInt, typeof (long?)},
                  {SqlDbType.Binary, typeof (byte[])},
                  {SqlDbType.Image, typeof (byte[])},
                  {SqlDbType.Timestamp, typeof (byte[])},
                  {SqlDbType.VarBinary, typeof (byte[])},
                  {SqlDbType.Bit, typeof (bool?)},
                  {SqlDbType.Char, typeof (string)},
                  {SqlDbType.NChar, typeof (string)},
                  {SqlDbType.NText, typeof (string)},
                  {SqlDbType.NVarChar, typeof (string)},
                  {SqlDbType.Text, typeof (string)},
                  {SqlDbType.VarChar, typeof (string)},
                  {SqlDbType.Xml, typeof (string)},
                  {SqlDbType.DateTime, typeof (DateTime?)},
                  {SqlDbType.SmallDateTime, typeof (DateTime?)},
                  {SqlDbType.Date, typeof (DateTime?)},
                  {SqlDbType.Time, typeof (DateTime?)},
                  {SqlDbType.DateTime2, typeof (DateTime?)},
                  {SqlDbType.Decimal, typeof (decimal?)},
                  {SqlDbType.Money, typeof (decimal?)},
                  {SqlDbType.SmallMoney, typeof (decimal?)},
                  {SqlDbType.Float, typeof (double?)},
                  {SqlDbType.Int, typeof (int?)},
                  {SqlDbType.Real, typeof (float?)},
                  {SqlDbType.UniqueIdentifier, typeof (Guid?)},
                  {SqlDbType.SmallInt, typeof (short?)},
                  {SqlDbType.TinyInt, typeof (byte?)},
                  {SqlDbType.Variant, typeof (object)},
                  {SqlDbType.Udt, typeof (object)},
                  {SqlDbType.Structured, typeof (DataTable)},
                  {SqlDbType.DateTimeOffset, typeof (DateTimeOffset)}
              };

        private static readonly Dictionary<DbType, Type> DbTypeMapToType
            = new Dictionary<DbType, Type>
              {
                  {DbType.Byte, typeof (byte)},
                  {DbType.SByte, typeof (sbyte)},
                  {DbType.Int16, typeof (short)},
                  {DbType.UInt16, typeof (ushort)},
                  {DbType.Int32, typeof (int)},
                  {DbType.UInt32, typeof (uint)},
                  {DbType.Int64, typeof (long)},
                  {DbType.UInt64, typeof (ulong)},
                  {DbType.Single, typeof (float)},
                  {DbType.Double, typeof (double)},
                  {DbType.Decimal, typeof (decimal)},
                  {DbType.Boolean, typeof (bool)},
                  {DbType.String, typeof (string)},
                  {DbType.StringFixedLength, typeof (char)},
                  {DbType.Guid, typeof (Guid)},
                  {DbType.DateTime, typeof (DateTime)},
                  {DbType.DateTimeOffset, typeof (DateTimeOffset)},
                  {DbType.Binary, typeof (byte[])}
              };

        private static readonly Dictionary<DbType, Type> DbTypeMapToNullableType
            = new Dictionary<DbType, Type>
              {
                  {DbType.Byte, typeof (byte?)},
                  {DbType.SByte, typeof (sbyte?)},
                  {DbType.Int16, typeof (short?)},
                  {DbType.UInt16, typeof (ushort?)},
                  {DbType.Int32, typeof (int?)},
                  {DbType.UInt32, typeof (uint?)},
                  {DbType.Int64, typeof (long?)},
                  {DbType.UInt64, typeof (ulong?)},
                  {DbType.Single, typeof (float?)},
                  {DbType.Double, typeof (double?)},
                  {DbType.Decimal, typeof (decimal?)},
                  {DbType.Boolean, typeof (bool?)},
                  {DbType.StringFixedLength, typeof (char?)},
                  {DbType.Guid, typeof (Guid?)},
                  {DbType.DateTime, typeof (DateTime?)},
                  {DbType.DateTimeOffset, typeof (DateTimeOffset?)},
                  {DbType.Binary, typeof(byte[])}
              };

        public static DbType ToDbType(this Type type)
        {
            DbType dbType;
            if (TypeToDbType.TryGetValue(type, out dbType)) return dbType;
            throw new ArgumentOutOfRangeException("type", type, "Cannot map the Type to DbType");
        }

        public static Type ToClrType(this DbType dbType)
        {
            Type type;
            if (DbTypeMapToType.TryGetValue(dbType, out type)) return type;
            throw new ArgumentOutOfRangeException("dbType", dbType, "Cannot map the DbType to Type");
        }

        public static Type ToNullableClrType(this DbType dbType)
        {
            Type type;
            if (DbTypeMapToNullableType.TryGetValue(dbType, out type)) return type;
            throw new ArgumentOutOfRangeException("dbType", dbType, "Cannot map the DbType to Nullable Type");
        }

        public static Type ToClrType(this SqlDbType sqlDbType)
        {
            Type type;
            if (SqlDbTypeToType.TryGetValue(sqlDbType, out type)) return type;
            throw new ArgumentOutOfRangeException("sqlDbType", sqlDbType, "Cannot map the SqlDbType to Type");
        }

        public static Type ToNullableClrType(this SqlDbType sqlDbType)
        {
            Type type;
            if (SqlDbTypeToNullableType.TryGetValue(sqlDbType, out type)) return type;
            throw new ArgumentOutOfRangeException("sqlDbType", sqlDbType, "Cannot map the SqlDbType to Nullable Type");
        }

        public static SqlDbType ToSqlDbType(this DbType type)
        {
            SqlDbType sqldbType;
            if (SqlDbTypeToDBType.ContainsValue(type))
            {
                sqldbType = SqlDbTypeToDBType.FirstOrDefault(x => x.Value == type).Key;
                return sqldbType;
            }
            throw new ArgumentOutOfRangeException("type", type, "Cannot map the Type to DbType");
        }
    }
}