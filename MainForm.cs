/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 10:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace booleans
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		public class pin
		{
			public string denumire;
			public int Left;
			public int Top;
			public int Width;
			public int Height;
			public Color c;
			public pin(){}
			public pin(string pden, int pl, int pt,int pw, int ph, Color pc)
			{
				this.denumire= pden;
				this.Left = pl;
				this.Top = pt;
				this.Width = pw;
				this.Height = ph;
				this.c = pc;
			}
		}
		public List<Button> pins = new List<Button>();
		
		public void setPin2Button(int btnidx, ref pin rp)
		{
			pins[btnidx].Left = rp.Left;
			pins[btnidx].Top = rp.Top;
			pins[btnidx].Width = rp.Width;
			pins[btnidx].Height = rp.Height;
			pins[btnidx].Text = rp.denumire;
			pins[btnidx].BackColor = rp.c;
		}
		public void addPin(ref List<Button>lb, ref Button rb)
		{
			lb.Add(rb);
		}
		public void AddButtonPinToForm(int i)
		{
			this.Controls.Add(pins[i]);
			pins[i].Visible = true;
		}
		void Button1Click(object sender, EventArgs e)
		{
			pin x1 = new pin("I0.0", 10,10,5,5,Color.Black);
			Button tmpbtn = new Button();
			addPin(ref pins, ref tmpbtn);
			setPin2Button(0,ref x1);
			AddButtonPinToForm(0);
			
		}
		
		
		
		public class gate
		{
			
		}
		
		public class varm
		{
		
			public int AND(int a, int b)
			{
				if(a==1 && b==1)
				{return 1;}
				else
				{return 0;}
			}
			public int OR(int a, int b)
			{
				if(a==1 || b==1)
				{return 1;}
				else
				{return 0;}
			}
			public int NOT(int a)
			{
				if(a==1){return 0;}
				else{return 1;}
			}
			public int NAND(int a, int b)
			{
				if(a==1 && b==1)
				{return 0;}
				else
				{return 1;}
			}
			public int XOR(int a, int b)
			{
				if(a==1 && b==1)
				{return 0;}
				else if(a==1 ||b==1)
				{return 1;}
				else
				{return 0;}
			}
			public int XNOR(int a, int b)
			{
				if(a==1 && b==1)
				{return 1;}
				else if(a==1 ||b==1)
				{return 0;}
				else
				{return 1;}
			}
			
			
			
		}
	}
}
