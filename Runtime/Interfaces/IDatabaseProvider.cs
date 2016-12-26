/** 
* This file is part of Project Limitless.
* Copyright © 2016 Donovan Solms.
* Project Limitless
* https://www.projectlimitless.io
* 
* Project Limitless is free software: you can redistribute it and/or modify
* it under the terms of the Apache License Version 2.0.
* 
* You should have received a copy of the Apache License Version 2.0 with
* Project Limitless. If not, see http://www.apache.org/licenses/LICENSE-2.0.
*/

using System;
using System.Collections.Generic;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// a SQL-based database for data storage. Should provide CRUD
    /// functionality.
    /// </summary>
    public interface IDatabaseProvider
    {
        /// <summary>
        /// Query returning a single row.
        /// </summary>
        /// <typeparam name="T">The type to return the result as</typeparam>
        /// <param name="sql">The SQL query</param>
        /// <returns>The result as specified type</returns>
        T QuerySingle<T>(string sql);
        /// <summary>
        /// Query returning a single row with bound parameters.
        /// </summary>
        /// <typeparam name="T">The type to return the result as</typeparam>
        /// <param name="sql">The SQL query</param>
        /// <param name="args">The binding parameters</param>
        /// <returns>The result as specified type</returns>
        T QuerySingle<T>(string sql, params object[] args);
        /// <summary>
        /// Query returning multiple rows.
        /// </summary>
        /// <typeparam name="T">The type to return the result as</typeparam>
        /// <param name="sql">The SQL query</param>
        /// <returns>The result as specified type</returns>
        List<T> QueryMany<T>(string sql);
        /// <summary>
        /// Query returning multiple rows with bound parameters.
        /// </summary>
        /// <typeparam name="T">The type to return the result as</typeparam>
        /// <param name="sql">The SQL query</param>
        /// <param name="args">The binding parameters</param>
        /// <returns>The result as specified type</returns>
        List<T> QueryMany<T>(string sql, params object[] args);
        /// <summary>
        /// Insert into the database.
        /// </summary>
        /// <param name="sql">The insert query</param>
        /// <param name="args">The parameters to bind</param>
        /// <returns>The identity of the row returned</returns>
        dynamic Insert(string sql, params object[] args);
        /// <summary>
        /// Insert into the database by providing the object to insert as value.
        /// </summary>
        /// <typeparam name="T">The type of object to insert</typeparam>
        /// <param name="tableName">The name of the table to insert into</param>
        /// <param name="value">The object to insert</param>
        /// <returns>The identity of the row returned</returns>
        dynamic Insert<T>(string tableName, T value);
        /// <summary>
        /// Update a record of records.
        /// </summary>
        /// <param name="sql">The update query</param>
        /// <param name="args">The parameters to bind</param>
        /// <returns>The amount of rows affected /returns>
        int Update(string sql, params object[] args);
        /// <summary>
        /// Deletes a record or records.
        /// </summary>
        /// <param name="sql">The update query</param>
        /// <param name="args">The parameters to bind</param>
        /// <returns>The amount of rows affected</returns>
        int Delete(string sql, params object[] args);
    }
}
