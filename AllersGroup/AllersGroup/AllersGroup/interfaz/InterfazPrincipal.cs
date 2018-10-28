﻿using AllersGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllersGroup.interfaz;
using Transitions;

namespace AllersGroup
{
    public partial class InterfazPrincipal : Form
    {
        private Form infor;
        private Form recome;
        private Form grafi;

        Controlador modelo;
       
     
        public InterfazPrincipal()
        {
           
            InitializeComponent();
            infor = new Info(this);
            recome = new Recomendaciones(this);
            grafi = new Graficos(this);
        }

        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        public void info_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(infor, "Left", -10);
            Visible = false;
            infor.Show();
            t.run();
           
        }

        public void recom_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_Bounce(2000));
            t.add(recome, "Left", 10);
            Visible = false;
            recome.Show();
            t.run();
        }

        public void graf_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_Bounce(2000));
            t.add(grafi, "Top", -10);
            Visible = false;
            grafi.Show();
            t.run();
        }
    }
}