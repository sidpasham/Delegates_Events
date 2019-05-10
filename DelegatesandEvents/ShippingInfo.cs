using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    public delegate void CalculateShippingFee(double amount, ref double fee);
    abstract class BaseShippingZone
    {
        public bool isHighRisk;

        public virtual void CalcFee(Double amount, ref double fee) { }

        public static BaseShippingZone GetShippingZone(string zoneName)
        {
            if (zoneName.ToLower().Contains("zone1"))
            {
                return new Zone1();
            }
            else if (zoneName.ToLower().Contains("zone2"))
            {
                return new Zone2();
            }
            else if (zoneName.ToLower().Contains("zone3"))
            {
                return new Zone3();
            }
            else if (zoneName.ToLower().Contains("zone4"))
            {
                return new Zone4();
            }

            return null;
        }
    }

    class Zone1 : BaseShippingZone
    {
        public Zone1()
        {
            this.isHighRisk = false;
        }

        public override void CalcFee(double amount, ref double fee)
        {
            fee = ((amount * 25) / 100);
        }
    }

    class Zone2 : BaseShippingZone
    {
        public Zone2()
        {
            this.isHighRisk = true;
        }

        public override void CalcFee(double amount, ref double fee)
        {
            fee = ((amount * 12) / 100);
        }
    }

    class Zone3 : BaseShippingZone
    {
        public Zone3()
        {
            this.isHighRisk = false;
        }

        public override void CalcFee(double amount, ref double fee)
        {
            fee = ((amount * 8) / 100);
        }
    }

    class Zone4 : BaseShippingZone
    {
        public Zone4()
        {
            this.isHighRisk = true;
        }

        public override void CalcFee(double amount, ref double fee)
        {
            fee = ((amount * 15) / 100);
        }
    }
}
