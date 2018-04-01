/*
 * Created by SharpDevelop.
 * User: leenovoz510
 * Date: 3/30/2018
 * Time: 3:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace ModernUI
{
	
	public partial class data : MetroForm
	{	List<Process> processList;
		int ProcessNumber=0  ;
		int ProcessCounter=0 ;
		int flagg=0;
		int simulateflag=0;
		public data()
		{
			InitializeComponent();
			dataGridView1.Visible = true;
			textBox6.Enabled = false;	
			comboBox1.Enabled = false;
			textBox1.Enabled=false;
			textBox3.Enabled=false;
			textBox5.Enabled=false;
			label2.Visible=false;
			label3.Text="To use another scheduler, please click on simulate again";
		}
void reset(){processList = new List<Process>();}		
void MainFormLoad(object sender, EventArgs e){}
void MetroLabel2Click(object sender, EventArgs e){}
void MetroLabel5Click(object sender, EventArgs e){}	
void GroupBox1Enter(object sender, EventArgs e){}
void GroupBox2Enter(object sender, EventArgs e){}
		
		void MetroButton2Click(object sender, EventArgs e)
		{	
			if(simulateflag!=0){
				Application.Restart();
				Environment.Exit(0);
			
			}else{
			textBox1.Text="";
			textBox3.Text="";
			textBox5.Text="";
			if(ProcessCounter == ProcessNumber){
				
				Algo algo = new Algo(WaitingCalc);
                if (metroRadioButton1.Checked)
                {
                    algo.FCFS(processList);
                    metroRadioButton1.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                }
                if (metroRadioButton4.Checked)
                {

                    algo.SJFN(processList);
                    metroRadioButton4.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                }
                if (metroRadioButton2.Checked)
                {
                    algo.preemtiveSJF(processList);
                    metroRadioButton2.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                }
                if (metroRadioButton5.Checked)
                {
                    algo.nonPreemtivePriority(processList);
                    metroRadioButton5.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                }
                if (metroRadioButton3.Checked)
                {
                    algo.preemtivePriority(processList);
                    metroRadioButton3.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                }
                if (metroRadioButton6.Checked)
                {	
                	int quantum = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    algo.RR(processList, quantum);
                    metroRadioButton6.Checked=false;
					textBox6.Enabled = false;	
					comboBox1.Enabled = false;
					textBox1.Enabled=false;
					textBox3.Enabled=false;
					textBox5.Enabled=false;
					label2.Visible=false;
					metroButton3.Enabled=false;
					comboBox2.Enabled=false;
					simulateflag++;
                    
                	}
                dataGridView1.DataSource = algo.showGrantChart();
                dataGridView1.Visible = true;
				ProcessNumber=0;
				ProcessCounter=0;
				reset();
				label3.Visible=Enabled;
				
			}else{
				DialogResult result = MessageBox.Show("Entered processes not equal to Number of processes selected\nApplication will restart", "", MessageBoxButtons.OK);
				if(result==DialogResult.OK){
				Application.Restart();
				Environment.Exit(0);}
			}
			}}
		
		void MetroRadioButton5CheckedChanged(object sender, EventArgs e)
		{	
			if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = true;
			//NoProcess.Enabled = true;				
				comboBox1.Enabled = false;
		}
			
		void MetroRadioButton6CheckedChanged(object sender, EventArgs e)
		{
						if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = false;
			comboBox1.Enabled=true;
		}
		
		void MetroRadioButton3CheckedChanged(object sender, EventArgs e)
		{
						if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = true;
			//NoProcess.Enabled = true;							
				comboBox1.Enabled = false;
		}
		
		
		void MetroRadioButton2CheckedChanged(object sender, EventArgs e)
		{
						if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = false;
			//NoProcess.Enabled = true;							
				comboBox1.Enabled = false;
		}
		
		void MetroRadioButton4CheckedChanged(object sender, EventArgs e)
		{
						if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = false;
			//NoProcess.Enabled = true;							
				comboBox1.Enabled = false;
		}
		
		void MetroRadioButton1CheckedChanged(object sender, EventArgs e)
		{
						if(ProcessCounter!=0){
				metroButton2.Enabled=true;
			}
			textBox6.Enabled = false;
			//NoProcess.Enabled = true;							
				comboBox1.Enabled = false;
		}
		
		void MetroToolTip1Popup(object sender, PopupEventArgs e)
		{
			
		}
		
		void MetroUserControl1Load(object sender, EventArgs e)
		{
			
		}
		
		void HtmlToolTip1Popup(object sender, PopupEventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
			
		}
		
		void MetroLabel7Click(object sender, EventArgs e)
		{
			
		}
	
		
		
		void MetroButton3Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox5.Text)) {
				DialogResult result = MessageBox.Show("Process data is missing\nApplication will restart", "", MessageBoxButtons.OK);
				if(result==DialogResult.OK){
				Application.Restart();
				Environment.Exit(0);}
			}else{
			if (flagg==0){
			reset();
			flagg=1;
			}
			if(metroRadioButton3.Checked||metroRadioButton5.Checked){
			if (string.IsNullOrWhiteSpace(textBox6.Text)) {
			DialogResult result = MessageBox.Show("Process data is missing\nApplication will restart", "", MessageBoxButtons.OK);
			if(result==DialogResult.OK){
			Application.Restart();
			Environment.Exit(0);}}
			if(!string.IsNullOrWhiteSpace(textBox5.Text)){
			if(textBox5.Text!="0"){
			processList.Add(new Process(textBox1.Text , Convert.ToInt32(textBox3.Text) , Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text)));
           	ProcessCounter++;
           	dataGridView2.Rows.Add(textBox1.Text,textBox3.Text,textBox5.Text,textBox6.Text,comboBox1.SelectedItem);
           	comboBox1.Enabled=false;
			textBox1.Text="";
			textBox3.Text="";
			textBox5.Text="";
			textBox6.Text="";
          
			label2.Text="Enter "+(ProcessNumber-ProcessCounter)+" processes";
				if(ProcessNumber-ProcessCounter==0){
				metroButton3.Enabled=false;
				textBox6.Enabled = false;	
				comboBox1.Enabled = false;
				textBox1.Enabled=false;
				textBox3.Enabled=false;
				textBox5.Enabled=false;
				label2.Visible=false;
				if(metroRadioButton1.Checked==true||metroRadioButton2.Checked==true||metroRadioButton3.Checked==true||metroRadioButton4.Checked==true||metroRadioButton5.Checked==true||metroRadioButton6.Checked==true){metroButton2.Enabled=true;}
			}
				}
			else{
				DialogResult result = MessageBox.Show("Burst time cannot be zero\nApplication will restart", "", MessageBoxButtons.OK);
				if(result==DialogResult.OK){
				Application.Restart();
				Environment.Exit(0);}
			}
			}
			else{
				DialogResult result = MessageBox.Show("Burst time cannot be empty\nApplication will restart", "", MessageBoxButtons.OK);
				if(result==DialogResult.OK){
				Application.Restart();
				Environment.Exit(0);}
			}
				}
			else{
			if(textBox5.Text!="0"){
			processList.Add(new Process(textBox1.Text , Convert.ToInt32(textBox3.Text) , Convert.ToInt32(textBox5.Text)));
								dataGridView2.Rows.Add(textBox1.Text,textBox3.Text,textBox5.Text,textBox6.Text,comboBox1.SelectedItem);
								           	comboBox1.Enabled=false;
           	ProcessCounter++;
			textBox1.Text="";
			textBox3.Text="";
			textBox5.Text="";
			label2.Text="Enter "+(ProcessNumber-ProcessCounter)+" processes";
			if(ProcessNumber-ProcessCounter==0){
				metroButton3.Enabled=false;
								textBox6.Enabled = false;	
				comboBox1.Enabled = false;
				textBox1.Enabled=false;
				textBox3.Enabled=false;
				textBox5.Enabled=false;
				label2.Visible=false;
						if(metroRadioButton1.Checked==true||metroRadioButton2.Checked==true||metroRadioButton3.Checked==true||metroRadioButton4.Checked==true||metroRadioButton5.Checked==true||metroRadioButton6.Checked==true){metroButton2.Enabled=true;}
			}
				}
			else{
				DialogResult result = MessageBox.Show("Burst time cannot be zero\nApplication will restart", "", MessageBoxButtons.OK);
				if(result==DialogResult.OK){
				Application.Restart();
				Environment.Exit(0);}
			}
				}}}
		void MetroButton1Click(object sender, EventArgs e)
		{	
			ProcessNumber = Convert.ToInt32(comboBox2.SelectedItem.ToString());
			textBox1.Enabled=true;
			textBox3.Enabled=true;
			textBox5.Enabled=true;
			label2.Visible=true;
			label2.Text="Enter "+ProcessNumber+" processes";
			metroButton3.Enabled=true;
			comboBox2.Enabled=false;
			metroButton1.Enabled=false;
			
			}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
					
		}
		
		void MetroLabel4Click(object sender, EventArgs e)
		{
			
		}
		
		void WaitingCalcTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void GroupBox3Enter(object sender, EventArgs e)
		{
			
		}
		
		void NoProcessTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
		metroButton1.Enabled=true;			
		}
	}
}
