using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
//using System.Data.OracleClient;

namespace Conndb
{
    public class dbConnSQL
    {
        private static string ConnString = "";
        private static OracleCommand _OraCommand = null;
        private static OracleConnection _OraConnection = null;

        public static Dictionary<string, string> QueryParm { get; set; }

        /// <summary>
        /// data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = [아이피주소])(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = [서비스이름])));USER ID=[아이디];PASSWORD=[비밀번호];";
        /// DB 연결 String
        /// </summary>
        private static void SetConnectionString()
        {
            try
            {
                ConnString = string.Format("USER ID={0};PASSWORD={1};data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS= (PROTOCOL = TCP)(HOST={2})(PORT ={3})))(CONNECT_DATA =(SERVICE_NAME ={4})))", new object[] { dbConnInfo.DataBaseID, dbConnInfo.DataBasePwd, dbConnInfo.ServerIP, dbConnInfo.DataBasePort, dbConnInfo.DatabaseSID });
            }
            catch
            {
                throw;
            }
        }

        //private static void SetConnectionStringHH()
        //{
        //    try
        //    {
        //        ConnString = string.Format("USER ID={0};PASSWORD={1};data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS= (PROTOCOL = TCP)(HOST={2})(PORT ={3})))(CONNECT_DATA =(SERVICE_NAME ={4})))", new object[] { dbConnInfo.DataBaseID, dbConnInfo.DataBasePwd, dbConnInfo.ServerIP, dbConnInfo.DataBasePort, dbConnInfo.DatabaseSID });
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        /// <summary>
        /// Oracle DB Connection.
        /// </summary>
        private static void DataBaseConnect()
        {
            try
            {
                SetConnectionString();

                OracleConnection connection = new OracleConnection
                {
                    ConnectionString = ConnString
                };
                _OraConnection = connection;
                if (_OraConnection.State == ConnectionState.Open)
                {
                    _OraConnection.Close();
                }
                _OraConnection.Open();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Oracle DATABASE 연결 해제
        /// </summary>
        private static void DatabaseDisConnect()
        {
            try
            {
                if (_OraConnection.State == ConnectionState.Open)
                {
                    _OraConnection.Close();
                    _OraConnection.Dispose();
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        ///  Oracle SQL문 실행(데이터 테이블 반환)
        /// </summary>
        /// <param name="sql">작성한 SQL문</param>
        /// <returns>실행한 SQL문 데이터 테이블 반환</returns>
        public static DataTable ExecuteSQLReturnDataTable(string sql)
        {
            DataTable dataTable = new DataTable();

            try
            {
                DataBaseConnect();

                _OraCommand = new OracleCommand(sql, _OraConnection);
                new OracleDataAdapter(_OraCommand).Fill(dataTable);

                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                DatabaseDisConnect();
            }
        }
        /// <summary>
        ///  Oracle SQL문 실행(데이터 테이블 반환)
        /// </summary>
        /// <param name="sql">작성한 SQL문 SP cursor Select</param>
        /// <returns>실행한 SQL문 데이터 테이블 반환</returns>
        public static DataTable ExecuteSQLOraSpReturnDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            try
            {
                DataBaseConnect();


                //_OraCommand = new OracleCommand(sql, _OraConnection);
                _OraCommand.Connection = _OraConnection;
                _OraCommand.CommandText = sql;
                //_OraCommand.Parameters.Add(new OracleParameter("DeliveryMstList", OracleDbType.RefCursor)).Direction = ParameterDirection.Output;
                _OraCommand.CommandType = CommandType.StoredProcedure;

                //_OraCommand.Parameters.Add(QueryParm["PARAM1"], OracleDbType.NVarchar2).Value = QueryParm["PARAM1_VALUE"];
                //_OraCommand.Parameters.Add(QueryParm["PARAM2"], OracleDbType.NVarchar2).Value = QueryParm["PARAM2_VALUE"];
                //var spCur = new OracleParameter(QueryParm["OPARAM"], OracleDbType.RefCursor, ParameterDirection.Output);
                _OraCommand.Parameters.Add("ar_deliveryfrom", OracleDbType.Varchar2).Value = "'20220101'";
                _OraCommand.Parameters.Add("ar_deliveryto", OracleDbType.Varchar2).Value = "'20220531'";
                var spCur = new OracleParameter("DeliveryMstList", OracleDbType.RefCursor, ParameterDirection.Output);
                _OraCommand.Parameters.Add(spCur);
                
                var da = new OracleDataAdapter(_OraCommand);
                da.ReturnProviderSpecificTypes = true;
                //da.Fill(dataTable);
                da.Fill(dataSet);
                //new OracleDataAdapter(_OraCommand).Fill(dataSet);

                //OracleDataReader odr = _OraCommand.ExecuteReader();
                

                //_OraCommand.ExecuteNonQuery();
                OracleDataAdapter odrer = new OracleDataAdapter(_OraCommand);  //((OracleRefCursor)_OraCommand.Parameters[QueryParm["OPARAM"]].Value).
                odrer.Fill(dataSet);
                //dataTable.Load(odrer);

                return dataTable;
            }
            catch(Exception ex)
            {
                throw new ApplicationException("what", ex);
            }
            finally
            {
                DatabaseDisConnect();
            }
        }
        /// <summary>
        /// Oracle SQL문 실행(데이터셋 반환)
        /// </summary>
        /// <param name="sql">작성한 SQL문</param>
        /// <returns>실행한 SQL문 데이터셋 반환</returns>
        public static DataSet ExcuteSQLReturnDataSet(string sql)
        {
            DataSet dataSet = new DataSet();

            try
            {
                DataBaseConnect();

                _OraCommand = new OracleCommand(sql, _OraConnection);
                new OracleDataAdapter(_OraCommand).Fill(dataSet);

                return dataSet;
            }
            catch
            {
                throw ;
            }
            finally
            {
                DatabaseDisConnect();
            }
        }

        //public static int ExcuteSQLReturnInt(string sql)
        //{
        //    try
        //    {
        //        DataBaseConnect();

        //        _OraCommand = new OracleCommand(sql, _OraConnection);
        //        return (Int32)_OraCommand.ExecuteScalar();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        DatabaseDisConnect();
        //    }
        //}

        // <summary>
        /// 트랜잭션 포함한 SQL문 실행
        /// </summary>
        /// <param name="sql">작성한 SQL문</param>
        public static void ExecuteTransactionSql(string sql)
        {
            OracleTransaction transaction = null;

            try
            {
                DataBaseConnect();
                transaction = _OraConnection.BeginTransaction();

                _OraCommand = new OracleCommand();
                _OraCommand.Connection = _OraConnection;
                _OraCommand.CommandType = CommandType.Text;
                _OraCommand.CommandTimeout = 60;
                _OraCommand.Transaction = transaction;
                _OraCommand.CommandText = sql;

                _OraCommand.ExecuteNonQuery();

                transaction.Commit();
            }

            catch (OracleException)
            {
                transaction.Rollback();
                throw;
            }
            catch
            {
                throw;
            }
            finally
            {
                DatabaseDisConnect();
            }
        }

        /// <summary>
        /// SQL문 실행
        /// </summary>
        /// <param name="sql">작성한 SQL문</param>
        public static void ExecuteSql(string sql)
        {
            OracleTransaction transaction = null;

            try
            {
                DataBaseConnect();

                _OraCommand = new OracleCommand();
                _OraCommand.Connection = _OraConnection;
                _OraCommand.CommandType = CommandType.Text;
                _OraCommand.CommandTimeout = 60;
                _OraCommand.CommandText = sql;

                _OraCommand.ExecuteNonQuery();
            }

            catch (OracleException)
            {
                transaction.Rollback();
                throw;
            }
            catch
            {
                throw;
            }
            finally
            {
                DatabaseDisConnect();
            }
        }
    }
}
