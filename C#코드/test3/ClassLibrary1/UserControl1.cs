using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using System.Security.Permissions;
using System.Linq;

namespace ClassLibrary1
{

    [ComVisible(true)]
    public delegate void TextEventHandlerDelegate(string msg);

    [Guid("5E603C7D-4B7C-412a-BAB4-063E5674F97A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IActiveXControl_Method
    {
        [DispId(1)]
        void add();
        [DispId(2)]
        int number
        {
            get;
            set;
        }
    }
    [Guid("93733F3F-2CDF-4979-ACEC-C53E98B10077")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IActiveXControl_Event
    {
        [DispId(1)]
        void textEvent(string msg);
    }



    [Guid("0FFC1A66-39DA-41bf-BB7C-43539A27D77C")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(IActiveXControl_Event))]
    public partial class UserControl1 : UserControl, IActiveXControl_Method
    {
    
      
        public string vari { get; set; } = "123";
        public int number { get; set; }


     
        public event TextEventHandlerDelegate textEvent;



  
        public UserControl1()
        {
            InitializeComponent();
           
            this.textBox2.Text = number.ToString();
        }

        public void Button1_Click_1(object sender, EventArgs e)
        {
            textEvent?.Invoke(textBox1.Text);
            textBox1.Text = "";
        }

        public void add()
        {
            number += 1;
        }

    }
}
