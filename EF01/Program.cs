﻿using EF01.Data;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            //var employee=context.Employees?.Where(E=>E.Id==10).FirstOrDefault();

            ///using(CompanyDbContext context = new CompanyDbContext())
            ///{
            ///Code
            ///}
            ///CompanyDbContext context = new CompanyDbContext();
            ///try
            ///{
            ///    //code
            ///}
            ///finally
            ///{
            ///    //Close Connection 
            ///   context.Dispose();
            ///}
        }
    }
}
