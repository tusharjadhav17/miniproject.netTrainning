﻿using Dapper;
using JWTAuthDemo.Models;

namespace JWTAuthDemo.Repository
{
    public interface IJWTAuthManager
    {
        Response<string> GenerateJWT(User user);
        Response<T> Execute_Command<T>(string query, DynamicParameters sp_params);
        Response<List<T>> getUserList<T>();
    }
}
