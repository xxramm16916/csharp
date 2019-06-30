using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TNE_v2.Database;

namespace TNE_v2.initiData
{
    public class init
    {
        private DatabasaTNE db;
        public init()
        {
            db = new DatabasaTNE();
        }

        public void dropData()
        {
            db.organization.RemoveRange(db.organization);
            db.subsidiary.RemoveRange(db.subsidiary);
            db.consumptionObject.RemoveRange(db.consumptionObject);
            db.electricitySupplyPoint.RemoveRange(db.electricitySupplyPoint);
            db.electricityMeasurementPoint.RemoveRange(db.electricityMeasurementPoint);
            db.electricEnergyMeter.RemoveRange(db.electricEnergyMeter);
            db.currentTransformer.RemoveRange(db.currentTransformer);
            db.voltageTransformer.RemoveRange(db.voltageTransformer);
            db.meteringDevice.RemoveRange(db.meteringDevice);
            db.SaveChanges();
        }
        private subsidiary addSubsidary(string name, string addr, organization org)
        {
            var res = new subsidiary();
            res.subsidiaryName = name;
            res.subsidiaryAddress = addr;
            res.organization = org;
            return res;
        }
        public void createTestData()
        {
            dropData();
            organization org = new organization()
            {
                organizationName = "TN",
                organizationAddress = "Adr1"
            };

            var sub1 = new subsidiary()
            {
                subsidiaryName = "TNE",
                subsidiaryAddress = "Adr2",
                organization = org
            };

            var sub2 = new subsidiary()
            {
                subsidiaryName = "TNIB",
                subsidiaryAddress = "Adr3",
                organization = org
            };

            org.subsidary = new List<subsidiary>{ sub1, sub2 };

            var cons1 = new consumptionObject()
            {
                consumptionObjectName = "ServerRoom",
                consumptionObjectAddress = "Adr4",
                subsidiary = sub1
            };

            var cons2 = new consumptionObject()
            {
                consumptionObjectName = "room05.03",
                consumptionObjectAddress = "Adr5",
                subsidiary = sub1
            };

            sub1.consumptionObject = new List<consumptionObject> { cons1, cons2 };

            var esp1 = new electricitySupplyPoint()
            {
                electricitySupplyPointName = "ESP1",
                electricitySupplyPointPower = "3",
                consumptionObject = cons1
            };

            var esp2 = new electricitySupplyPoint()
            {
                electricitySupplyPointName = "ESP2",
                electricitySupplyPointPower = "1",
                consumptionObject = cons1
            };

            cons1.electricitySupplyPoint = new List<electricitySupplyPoint> { esp1, esp2 };

            var emp1 = new electricityMeasurementPoint()
            {
                electricityMeasurementPointName = "EMP1",
                consumptionObject = cons1
            };

            var emp2 = new electricityMeasurementPoint()
            {
                electricityMeasurementPointName = "EMP2",
                consumptionObject = cons1
            };

            cons1.electricityMeasurementPoint = new List<electricityMeasurementPoint> { emp1, emp2 };

            var eem1 = new electricEnergyMeter()
            {
                electricEnergyMeterNumber = 1,
                electricEnergyMeterType = "Type1",
                electricEnergyMeterDate = new DateTime(2008, 5, 1, 8, 30, 52)
            };

            emp1.electricEnergyMeter = eem1;

            var vt1 = new voltageTransformer()
            {
                voltageTransformerNumber = 1,
                voltageTransformerType = "Type1",
                voltageTransformerDate = new DateTime(2008, 5, 1, 8, 30, 52),
                voltageTransformerKoeff = 3
            };

            emp1.voltageTransformer = vt1;

            var ct1 = new currentTransformer()
            {
                currentTransformerNumber = 1,
                currentTransformerType = "Type1",
                currentTransformerDate = new DateTime(2008, 5, 1, 8, 30, 52),
                currentTransformerKoeff = 3
            };

            emp1.currentTransformer = ct1;

            var md1 = new meteringDevice()
            {
                meteringDeviceDateRegistration = new DateTime(2018, 5, 1, 8, 30, 52),
                meteringDeviceDateRemoval = new DateTime(2019, 5, 1, 8, 30, 52),
                electricityMeasurementPoint = new List<electricityMeasurementPoint> { emp1, emp2 }
            };

            var md2 = new meteringDevice()
            {
                meteringDeviceDateRegistration = new DateTime(2017, 5, 1, 8, 30, 52),
                meteringDeviceDateRemoval = new DateTime(2019, 5, 1, 8, 30, 52),
                electricityMeasurementPoint = new List<electricityMeasurementPoint> { emp1, emp2 }
            };

            emp1.meteringDevice = new List<meteringDevice> { md1, md2 };
            emp2.meteringDevice = new List<meteringDevice> { md1, md2 };

            db.organization.Add(org);
            db.subsidiary.Add(sub1);
            db.subsidiary.Add(sub2);
            db.consumptionObject.Add(cons1);
            db.consumptionObject.Add(cons2);
            db.electricitySupplyPoint.Add(esp1);
            db.electricitySupplyPoint.Add(esp2);
            db.electricityMeasurementPoint.Add(emp1);
            db.electricityMeasurementPoint.Add(emp2);
            db.electricEnergyMeter.Add(eem1);
            db.voltageTransformer.Add(vt1);
            db.currentTransformer.Add(ct1);
            db.meteringDevice.Add(md1);
            db.meteringDevice.Add(md2);
            db.SaveChanges();
        }
}
}