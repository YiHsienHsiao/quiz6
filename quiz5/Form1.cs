using quiz5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _2015OOP_Quiz5_win
{
    public partial class Form1 : Form
    {
        private ArrayList shapeArr=new ArrayList();
        private static double[] densityArr = { 2.7, 7.87, 11.3};

        public Form1()
        {
            InitializeComponent();     
            lblPara1.Visible = false;
            txtPara1.Visible = false;  
            lblPara2.Visible = false;
            txtPara2.Visible = false;  
        }

        private void cboxShapeSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxShapeSet.SelectedIndex)
            { 
                case 0:
                    lblPara1.Visible = true;
                    txtPara1.Visible = true;  
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;                      
                    break;
                case 1:
                    lblPara1.Visible = true;
                    txtPara1.Visible = true; 
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case 2:
                    lblPara1.Visible = true;
                    txtPara1.Visible = true; 
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                case 3:
                    lblPara1.Visible = true;
                    txtPara1.Visible = true; 
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amount = shapeArr.Count;
            double density = densityArr[cboxMaterialSet.SelectedIndex];
            switch (cboxShapeSet.SelectedIndex)
            {
                case 0:
                    Ball ball = new Ball(double.Parse(txtPara1.Text),density);
                    shapeArr.Add(ball);
                    break;
                case 1:
                    Cube cube = new Cube(double.Parse(txtPara1.Text), density);
                    shapeArr.Add(cube);
                    break;
                case 2:
                    Cylinder cylinder = new Cylinder(double.Parse(txtPara1.Text), double.Parse(txtPara2.Text), density);
                    shapeArr.Add(cylinder);
                    break;
                case 3:
                    Pyramid pyramid = new Pyramid(double.Parse(txtPara1.Text), double.Parse(txtPara2.Text), density);
                    shapeArr.Add(pyramid);
                    break;
                default:
                    break;
            }
            txtShapeNum.Text = shapeArr.Count.ToString();
            txtAdd.AppendText(((Shape3D)shapeArr[amount]).ShowProperty() + Environment.NewLine);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtShowSolution.Clear();
            for (int i = 0; i < shapeArr.Count; i++)
            {
                txtShowSolution.AppendText(((Shape3D)shapeArr[i]).ShowResults() + Environment.NewLine);
            }
        }

        private bool CompareByVolumeAscent(Shape3D shapeA, Shape3D shapeB)
        {
            if (shapeA.Volume() > shapeB.Volume())
                return true;
            else
                return false;
        }
        private bool CompareByVolumeDescent(Shape3D shapeA, Shape3D shapeB)
        {
            if (shapeA.Volume() < shapeB.Volume())
                return true;
            else
                return false;
        }
        private bool CompareByWeightAscent(Shape3D shapeA, Shape3D shapeB)
        {
            if (shapeA.Weight() > shapeB.Weight())
                return true;
            else
                return false;
        }
        private bool CompareByWeightDescent(Shape3D shapeA, Shape3D shapeB)
        {
            if (shapeA.Weight() < shapeB.Weight())
                return true;
            else
                return false;
        }

        private delegate bool CompareFun(Shape3D shapeA, Shape3D shapeB);

        private void BubbleSort(ArrayList arr, CompareFun cmp)
        {
            for (int pass = 0; pass < arr.Count; pass++)
            {
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (cmp((Shape3D)arr[i], (Shape3D)arr[i + 1]))
                    {
                        Shape3D temp;
                        temp = (Shape3D)arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            switch (cmbSortMethod.SelectedIndex)
            { 
                case 0:
                    if (rdbSortAscent.Checked)
                        BubbleSort(shapeArr, CompareByWeightAscent);
                    else if(rdbSortDescent.Checked)
                        BubbleSort(shapeArr, CompareByWeightDescent);
                    break;
                case 1:
                    if (rdbSortAscent.Checked)
                        BubbleSort(shapeArr, CompareByVolumeAscent);
                    else if (rdbSortDescent.Checked)
                        BubbleSort(shapeArr,CompareByVolumeDescent);
                    break;
            }
            Display(shapeArr);

        }
        public void Display(ArrayList arr)
        {
            txtShowSolution.Clear();
            for (int i = 0; i < arr.Count; i++)
            { 
                txtShowSolution.AppendText(((Shape3D)arr[i]).ShowResults()+Environment.NewLine);               
            }
        }
        
    }
}