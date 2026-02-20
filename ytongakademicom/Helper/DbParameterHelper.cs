using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data;

namespace ytongakademicom.Helper
{
	public class DbParameterHelper
	{
		private readonly DbContext dbContext;
		private readonly DbConnection dbConnection;
		private readonly DbCommand dbCommand;
		public DbParameterHelper(DbContext dbContext)
		{
			this.dbContext = dbContext;
			dbConnection = dbContext.Database.GetDbConnection();
			dbCommand = dbConnection.CreateCommand();
		}
		public DbParameter CreateParameter(string name, object value = null, DbType dbType = DbType.String, byte precision = 0, byte scale = 0, ParameterDirection parameterDirection = ParameterDirection.Input)
		{
			var parameter = dbCommand.CreateParameter();
			parameter.DbType = dbType;
			parameter.Scale = scale;
			parameter.Precision = precision;
			parameter.ParameterName = name;
			parameter.Value = value;
			parameter.Direction = parameterDirection;

			return parameter;
		}
	}
}
