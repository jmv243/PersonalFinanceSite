namespace PersonalFinanceSite.Db
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using PersonalFinanceSite.Db.Types;    
    using System.Collections.Generic;

    public class PersonalFinanceSiteData : DbContext
    {
        // Your context has been configured to use a 'PersonalFinanceSiteData' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PersonalFinanceSite.Db.PersonalFinanceSiteData' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonalFinanceSiteData' 
        // connection string in the application configuration file.
        public PersonalFinanceSiteData()
            : base("name=PersonalFinanceSiteData")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<AddressInformation> AddressInformation { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<LoginInformation> LoginInformation { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}