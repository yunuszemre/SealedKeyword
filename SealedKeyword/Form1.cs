using System;
using System.Windows.Forms;

namespace SealedKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Mühülü?? Sealed ==> sealed modifier..... Kalıtım veremez!!
        /*
         * 
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class X
    {
        protected virtual string F()
        {
            return "X => F method";
        }
        protected virtual string F2()
        {
            return "X => F2 method";
        }

    }
    public class Y : X
    {
        protected  override string F2()
        {
            return "Y => F2 methodu";
        }
        protected sealed override string F()
        {
            return "Y => F methodu";
        }
    }
    class Z : Y
    {
        //Error => Z.F(): cannot override inherited member Y.F() because it is sealed
        //protected override string F()
        //{
        //      return base.F();
        //}
        protected override string F2()
        {
            return "Z => F2 methodu";
        }
    }
}
