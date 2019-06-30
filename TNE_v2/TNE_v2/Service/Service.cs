using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TNE_v2.Database;
using TNE_v2.Models;

namespace TNE_v2.Service
{
    public class Service
    {
        private DatabasaTNE db;

        public Service()
        {
            db = new DatabasaTNE();
        }


        public List<CurrentTransformerModel> getOverdueCurrentTransformers(string consumptionObjectName)
        {
            List<CurrentTransformerModel> CurrentTransformers = new List<CurrentTransformerModel>();
            var Transformers = from cons in db.consumptionObject
                               join emp in db.electricityMeasurementPoint on cons.consumptionObjectId equals emp.consumptionObject.consumptionObjectId
                               join ct in db.currentTransformer on emp.currentTransformer.currentTransformerId equals ct.currentTransformerId
                               where cons.consumptionObjectName == consumptionObjectName
                               where ct.currentTransformerDate <= DateTime.Now
                               select ct;

            foreach (var ct in Transformers)
            {

                CurrentTransformerModel newCt = new CurrentTransformerModel(ct.currentTransformerNumber,
            ct.currentTransformerType, ct.currentTransformerDate, ct.currentTransformerKoeff);
                CurrentTransformers.Add(newCt);
            }
            return CurrentTransformers;
        }

        public List<VoltageTransformerModel> getOverdueVoltageTransformers(string consumptionObjectName)
        {
            List<VoltageTransformerModel> VoltageTransformers = new List<VoltageTransformerModel>();
            var Transformers = from cons in db.consumptionObject
                                       join emp in db.electricityMeasurementPoint on cons.consumptionObjectId equals emp.consumptionObject.consumptionObjectId
                                       join vm in db.voltageTransformer on emp.voltageTransformer.voltageTransformerId equals vm.voltageTransformerId
                                       where cons.consumptionObjectName == consumptionObjectName
                                       where vm.voltageTransformerDate <= DateTime.Now
                                       select vm;

            foreach (var vm in Transformers)
            {

                VoltageTransformerModel newVm = new VoltageTransformerModel(vm.voltageTransformerNumber,
                        vm.voltageTransformerType, vm.voltageTransformerDate, vm.voltageTransformerKoeff);
                VoltageTransformers.Add(newVm);
            }
            return VoltageTransformers;
        }

        public List<ElectricEnergyMeterModel> getOverdueEnergyMeters(string consumptionObjectName)
        {
            List<ElectricEnergyMeterModel> EnergyMeters = new List<ElectricEnergyMeterModel>();
            var electricEnergyMeters = from cons in db.consumptionObject
                                       join emp in db.electricityMeasurementPoint on cons.consumptionObjectId equals emp.consumptionObject.consumptionObjectId
                                       join eem in db.electricEnergyMeter on emp.electricEnergyMeter.electricEnergyMeterId equals eem.electricEnergyMeterId
                                       where cons.consumptionObjectName == consumptionObjectName
                                       where eem.electricEnergyMeterDate <= DateTime.Now
                                       select eem;

            foreach (var eem in electricEnergyMeters)
            {
             
                    ElectricEnergyMeterModel newEEM = new ElectricEnergyMeterModel(eem.electricEnergyMeterNumber,
                            eem.electricEnergyMeterType, eem.electricEnergyMeterDate);
                    EnergyMeters.Add(newEEM);
            }
            return EnergyMeters;
        }
        public List<MeteringDeviceModel> GetmeteringDevice(int year)
        {
            List<MeteringDeviceModel> meteringDevices = new List<MeteringDeviceModel>();
            var res = db.meteringDevice.Where(md => md.meteringDeviceDateRegistration >= new DateTime(year, 1, 1));
            foreach(var meteringDevice in res)
            {
                MeteringDeviceModel newMD = new MeteringDeviceModel(meteringDevice.meteringDeviceId,
                    meteringDevice.meteringDeviceDateRegistration, meteringDevice.meteringDeviceDateRemoval);
                meteringDevices.Add(newMD);
            }
            return meteringDevices;
        }

        public consumptionObject ConsumptionObjectByName(string name)
        {

            var consumptionObject = db.consumptionObject.Where(cons => cons.consumptionObjectName == name)
                .FirstOrDefault<consumptionObject>();

            return consumptionObject;
        }


        public electricityMeasurementPoint AddEMP(consumptionObject cons, AddEMPModel emp)
        {
            var empNew = new electricityMeasurementPoint()
            {
                electricityMeasurementPointName = emp.electricityMeasurementPointName,
                consumptionObject = cons
            };

            //cons1.electricityMeasurementPoint = new List<electricityMeasurementPoint> { emp1, emp2 };

            var eemNew = new electricEnergyMeter()
            {
                electricEnergyMeterNumber = emp.electricEnergyMeterNumber,
                electricEnergyMeterType = emp.electricEnergyMeterType,
                electricEnergyMeterDate = emp.electricEnergyMeterDate
            };

            empNew.electricEnergyMeter = eemNew;

            var vtNew = new voltageTransformer()
            {
                voltageTransformerNumber = emp.voltageTransformerNumber,
                voltageTransformerType = emp.voltageTransformerType,
                voltageTransformerDate = emp.voltageTransformerDate,
                voltageTransformerKoeff = emp.voltageTransformerKoeff
            };

            empNew.voltageTransformer = vtNew;

            var ctNew = new currentTransformer()
            {
                currentTransformerNumber = emp.currentTransformerNumber,
                currentTransformerType = emp.currentTransformerType,
                currentTransformerDate = emp.currentTransformerDate,
                currentTransformerKoeff = emp.currentTransformerKoeff
            };

            empNew.currentTransformer = ctNew;
            db.electricityMeasurementPoint.Add(empNew);
            db.electricEnergyMeter.Add(eemNew);
            db.voltageTransformer.Add(vtNew);
            db.currentTransformer.Add(ctNew);
            db.SaveChanges();

            return empNew;
        }
    }
}