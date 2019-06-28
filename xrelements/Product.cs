using System;

namespace xrelements
{
    public abstract class Product
    {
        private int qty;
        private ProductCode code;
        private int smpack, mdpack, lgpack;
        private double smprice, mdprice, lgprice;
        private double total = 0.00;
        protected int sm = 0, md = 0, lg = 0;
        protected string mess = "";
        protected int tmpQty;

        public Product(int qty, ProductCode code)
        {
            this.qty = qty;
            this.code = code;
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public ProductCode Code
        {
            get { return code; }
            set { code = value; }
        }

        public int SmallPack
        {
            get { return smpack; }
            set { smpack = value; }
        }

        public int MediumPack
        {
            get { return mdpack; }
            set { mdpack = value; }
        }

        public int LargePack
        {
            get { return lgpack; }
            set { lgpack = value; }
        }

        public double SmallPrice
        {
            get { return smprice; }
            set { smprice = value; }
        }

        public double MediumPrice
        {
            get { return mdprice; }
            set { mdprice = value; }
        }

        public double LargePrice
        {
            get { return lgprice; }
            set { lgprice = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public virtual void Order(int qty)
        {
            tmpQty = qty;
           
            while (tmpQty != 0)
            {
                if ((tmpQty >= LargePack) && (Convert.ToDecimal(tmpQty) / Convert.ToDecimal(LargePack)) % 1 == 0)
                {
                    tmpQty -= LargePack;
                    lg += 1;
                    Total += LargePrice;
                }
                else if ((tmpQty >= MediumPack))
                {
                    tmpQty -= MediumPack;
                    md += 1;
                    Total += MediumPrice;
                }
                else if ((SmallPack != 0) && (tmpQty >= SmallPack) && (tmpQty < MediumPack))
                {
                    tmpQty -= SmallPack;
                    sm += 1;
                    Total += SmallPrice;
                }
            }             
        }

        public string Output()
        {
            mess = qty + " " + code + " $" + Total.ToString("F") + "\n";

            if (lg != 0)
                mess += lg + " x " + LargePack + " $" + LargePrice + "\n";
            if (md != 0)
                mess += md + " x " + MediumPack + " $" + MediumPrice + "\n";
            if (sm != 0)
                mess += sm + " x " + SmallPack + " $" + SmallPrice + "\n";

            return mess;
        }
    }

    public class SH3 : Product
    {
        public SH3(int qty, ProductCode code) : base(qty, code)
        {
            Qty = qty;
            Code = code;

            //Set Pack Sizes
            SmallPack = 0;
            MediumPack = 3;
            LargePack = 5;

            //Set Pack Prices
            SmallPrice = 0.00;
            MediumPrice = 2.99;
            LargePrice = 4.49;
        }
    }

    public class YT2 : Product
    {
        public YT2(int qty, ProductCode code) : base(qty, code)
        {
            Qty = qty;
            Code = code;

            //Set Pack Sizes
            SmallPack = 4;
            MediumPack = 10;
            LargePack = 15;

            //Set Pack Prices
            SmallPrice = 4.95;
            MediumPrice = 9.95;
            LargePrice = 13.95;
        }
    }

    public class TR : Product
    {
        public TR(int qty, ProductCode code) : base(qty, code)
        {
            Qty = qty;
            Code = code;

            //Set Pack Sizes
            SmallPack = 3;
            MediumPack = 5;
            LargePack = 9;

            //Set Pack Prices
            SmallPrice = 2.95;
            MediumPrice = 4.45;
            LargePrice = 7.99;
        }

        public override void Order(int qty)
        {
            tmpQty = qty;
            
            while (tmpQty != 0)
            {
                if (tmpQty >= LargePack)
                {
                    tmpQty -= LargePack;
                    lg += 1;
                    Total += LargePrice;
                }
                else if ((tmpQty >= MediumPack))
                {
                    tmpQty -= MediumPack;
                    md += 1;
                    Total += MediumPrice;
                }
                else if ((SmallPack != 0) && (tmpQty >= SmallPack))
                {
                    tmpQty -= SmallPack;
                    sm += 1;
                    Total += SmallPrice;
                }
            }
        }
    }
}
