namespace TNE_v2.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabasaTNE : DbContext
    {
        // Контекст настроен для использования строки подключения "DatabasaTNE" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TNE_v2.Database.DatabasaTNE" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DatabasaTNE" 
        // в файле конфигурации приложения.
        public DatabasaTNE()
            : base("name=DatabasaTNE")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DatabasaTNE>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatabasaTNE>());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<organization> organization { get; set; }
        public virtual DbSet<subsidiary> subsidiary { get; set; }
        public virtual DbSet<consumptionObject> consumptionObject { get; set; }
        public virtual DbSet<electricitySupplyPoint> electricitySupplyPoint { get; set; }
        public virtual DbSet<electricityMeasurementPoint> electricityMeasurementPoint { get; set; }
        public virtual DbSet<meteringDevice> meteringDevice { get; set; }
        public virtual DbSet<electricEnergyMeter> electricEnergyMeter { get; set; }
        public virtual DbSet<currentTransformer> currentTransformer { get; set; }
        public virtual DbSet<voltageTransformer> voltageTransformer { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}