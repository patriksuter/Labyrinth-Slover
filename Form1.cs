using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Laby_ZP3
{
    public partial class Form1 : Form
    {
        int[,] labyrinth = new int[,] {
 { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
 { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 3, 1 },
 { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1 },
 { 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 },
 { 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
 { 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
 { 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1 },
 { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
 { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1 },
 { 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 },
 { 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
 { 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1 },
 { 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1 },
 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1 },
 { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1 },
 { 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1 },
 { 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1 },
 { 1, 2, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1 },
 { 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 },
 { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
        //Keine Wand = 0 ; Wand = 1 ; Start = 2 ; Ziel = 3 ; [x,y]
        //Keine Wand = "Weiss" ; Wand = "Schwarz"
        //Start = "Grün" ; Ziel = "Rot" ; Pos = "Orange"
        int posx;
        int poszx;
        int posy;
        int poszy;
        char richtung = 'r'; //Hoch = u ; Runter = d ; Links = l ; Rechts = r
        public Form1()
        {
            InitializeComponent();
        }

        public Color farbe (int fnummer)
        {
            switch (fnummer)
            {
                case 0:
                    return System.Drawing.Color.White;
                case 1:
                    return System.Drawing.Color.Black;
                case 2:
                    return System.Drawing.Color.Green;
                case 3:
                    return System.Drawing.Color.Red;
                default:
                    return System.Drawing.SystemColors.Control;
            }
        }

        public void färben()
        {
            this.px0y0.BackColor = farbe(labyrinth[0, 0]);
            this.px0y1.BackColor = farbe(labyrinth[0, 1]);
            this.px0y2.BackColor = farbe(labyrinth[0, 2]);
            this.px0y3.BackColor = farbe(labyrinth[0, 3]);
            this.px0y4.BackColor = farbe(labyrinth[0, 4]);
            this.px0y5.BackColor = farbe(labyrinth[0, 5]);
            this.px0y6.BackColor = farbe(labyrinth[0, 6]);
            this.px0y7.BackColor = farbe(labyrinth[0, 7]);
            this.px0y8.BackColor = farbe(labyrinth[0, 8]);
            this.px0y9.BackColor = farbe(labyrinth[0, 9]);
            this.px0y10.BackColor = farbe(labyrinth[0, 10]);
            this.px0y11.BackColor = farbe(labyrinth[0, 11]);
            this.px0y12.BackColor = farbe(labyrinth[0, 12]);
            this.px0y13.BackColor = farbe(labyrinth[0, 13]);
            this.px0y14.BackColor = farbe(labyrinth[0, 14]);
            this.px0y15.BackColor = farbe(labyrinth[0, 15]);
            this.px0y16.BackColor = farbe(labyrinth[0, 16]);
            this.px0y17.BackColor = farbe(labyrinth[0, 17]);
            this.px0y18.BackColor = farbe(labyrinth[0, 18]);
            this.px0y19.BackColor = farbe(labyrinth[0, 19]);
            this.px1y0.BackColor = farbe(labyrinth[1, 0]);
            this.px1y1.BackColor = farbe(labyrinth[1, 1]);
            this.px1y2.BackColor = farbe(labyrinth[1, 2]);
            this.px1y3.BackColor = farbe(labyrinth[1, 3]);
            this.px1y4.BackColor = farbe(labyrinth[1, 4]);
            this.px1y5.BackColor = farbe(labyrinth[1, 5]);
            this.px1y6.BackColor = farbe(labyrinth[1, 6]);
            this.px1y7.BackColor = farbe(labyrinth[1, 7]);
            this.px1y8.BackColor = farbe(labyrinth[1, 8]);
            this.px1y9.BackColor = farbe(labyrinth[1, 9]);
            this.px1y10.BackColor = farbe(labyrinth[1, 10]);
            this.px1y11.BackColor = farbe(labyrinth[1, 11]);
            this.px1y12.BackColor = farbe(labyrinth[1, 12]);
            this.px1y13.BackColor = farbe(labyrinth[1, 13]);
            this.px1y14.BackColor = farbe(labyrinth[1, 14]);
            this.px1y15.BackColor = farbe(labyrinth[1, 15]);
            this.px1y16.BackColor = farbe(labyrinth[1, 16]);
            this.px1y17.BackColor = farbe(labyrinth[1, 17]);
            this.px1y18.BackColor = farbe(labyrinth[1, 18]);
            this.px1y19.BackColor = farbe(labyrinth[1, 19]);
            this.px2y0.BackColor = farbe(labyrinth[2, 0]);
            this.px2y1.BackColor = farbe(labyrinth[2, 1]);
            this.px2y2.BackColor = farbe(labyrinth[2, 2]);
            this.px2y3.BackColor = farbe(labyrinth[2, 3]);
            this.px2y4.BackColor = farbe(labyrinth[2, 4]);
            this.px2y5.BackColor = farbe(labyrinth[2, 5]);
            this.px2y6.BackColor = farbe(labyrinth[2, 6]);
            this.px2y7.BackColor = farbe(labyrinth[2, 7]);
            this.px2y8.BackColor = farbe(labyrinth[2, 8]);
            this.px2y9.BackColor = farbe(labyrinth[2, 9]);
            this.px2y10.BackColor = farbe(labyrinth[2, 10]);
            this.px2y11.BackColor = farbe(labyrinth[2, 11]);
            this.px2y12.BackColor = farbe(labyrinth[2, 12]);
            this.px2y13.BackColor = farbe(labyrinth[2, 13]);
            this.px2y14.BackColor = farbe(labyrinth[2, 14]);
            this.px2y15.BackColor = farbe(labyrinth[2, 15]);
            this.px2y16.BackColor = farbe(labyrinth[2, 16]);
            this.px2y17.BackColor = farbe(labyrinth[2, 17]);
            this.px2y18.BackColor = farbe(labyrinth[2, 18]);
            this.px2y19.BackColor = farbe(labyrinth[2, 19]);
            this.px3y0.BackColor = farbe(labyrinth[3, 0]);
            this.px3y1.BackColor = farbe(labyrinth[3, 1]);
            this.px3y2.BackColor = farbe(labyrinth[3, 2]);
            this.px3y3.BackColor = farbe(labyrinth[3, 3]);
            this.px3y4.BackColor = farbe(labyrinth[3, 4]);
            this.px3y5.BackColor = farbe(labyrinth[3, 5]);
            this.px3y6.BackColor = farbe(labyrinth[3, 6]);
            this.px3y7.BackColor = farbe(labyrinth[3, 7]);
            this.px3y8.BackColor = farbe(labyrinth[3, 8]);
            this.px3y9.BackColor = farbe(labyrinth[3, 9]);
            this.px3y10.BackColor = farbe(labyrinth[3, 10]);
            this.px3y11.BackColor = farbe(labyrinth[3, 11]);
            this.px3y12.BackColor = farbe(labyrinth[3, 12]);
            this.px3y13.BackColor = farbe(labyrinth[3, 13]);
            this.px3y14.BackColor = farbe(labyrinth[3, 14]);
            this.px3y15.BackColor = farbe(labyrinth[3, 15]);
            this.px3y16.BackColor = farbe(labyrinth[3, 16]);
            this.px3y17.BackColor = farbe(labyrinth[3, 17]);
            this.px3y18.BackColor = farbe(labyrinth[3, 18]);
            this.px3y19.BackColor = farbe(labyrinth[3, 19]);
            this.px4y0.BackColor = farbe(labyrinth[4, 0]);
            this.px4y1.BackColor = farbe(labyrinth[4, 1]);
            this.px4y2.BackColor = farbe(labyrinth[4, 2]);
            this.px4y3.BackColor = farbe(labyrinth[4, 3]);
            this.px4y4.BackColor = farbe(labyrinth[4, 4]);
            this.px4y5.BackColor = farbe(labyrinth[4, 5]);
            this.px4y6.BackColor = farbe(labyrinth[4, 6]);
            this.px4y7.BackColor = farbe(labyrinth[4, 7]);
            this.px4y8.BackColor = farbe(labyrinth[4, 8]);
            this.px4y9.BackColor = farbe(labyrinth[4, 9]);
            this.px4y10.BackColor = farbe(labyrinth[4, 10]);
            this.px4y11.BackColor = farbe(labyrinth[4, 11]);
            this.px4y12.BackColor = farbe(labyrinth[4, 12]);
            this.px4y13.BackColor = farbe(labyrinth[4, 13]);
            this.px4y14.BackColor = farbe(labyrinth[4, 14]);
            this.px4y15.BackColor = farbe(labyrinth[4, 15]);
            this.px4y16.BackColor = farbe(labyrinth[4, 16]);
            this.px4y17.BackColor = farbe(labyrinth[4, 17]);
            this.px4y18.BackColor = farbe(labyrinth[4, 18]);
            this.px4y19.BackColor = farbe(labyrinth[4, 19]);
            this.px5y0.BackColor = farbe(labyrinth[5, 0]);
            this.px5y1.BackColor = farbe(labyrinth[5, 1]);
            this.px5y2.BackColor = farbe(labyrinth[5, 2]);
            this.px5y3.BackColor = farbe(labyrinth[5, 3]);
            this.px5y4.BackColor = farbe(labyrinth[5, 4]);
            this.px5y5.BackColor = farbe(labyrinth[5, 5]);
            this.px5y6.BackColor = farbe(labyrinth[5, 6]);
            this.px5y7.BackColor = farbe(labyrinth[5, 7]);
            this.px5y8.BackColor = farbe(labyrinth[5, 8]);
            this.px5y9.BackColor = farbe(labyrinth[5, 9]);
            this.px5y10.BackColor = farbe(labyrinth[5, 10]);
            this.px5y11.BackColor = farbe(labyrinth[5, 11]);
            this.px5y12.BackColor = farbe(labyrinth[5, 12]);
            this.px5y13.BackColor = farbe(labyrinth[5, 13]);
            this.px5y14.BackColor = farbe(labyrinth[5, 14]);
            this.px5y15.BackColor = farbe(labyrinth[5, 15]);
            this.px5y16.BackColor = farbe(labyrinth[5, 16]);
            this.px5y17.BackColor = farbe(labyrinth[5, 17]);
            this.px5y18.BackColor = farbe(labyrinth[5, 18]);
            this.px5y19.BackColor = farbe(labyrinth[5, 19]);
            this.px6y0.BackColor = farbe(labyrinth[6, 0]);
            this.px6y1.BackColor = farbe(labyrinth[6, 1]);
            this.px6y2.BackColor = farbe(labyrinth[6, 2]);
            this.px6y3.BackColor = farbe(labyrinth[6, 3]);
            this.px6y4.BackColor = farbe(labyrinth[6, 4]);
            this.px6y5.BackColor = farbe(labyrinth[6, 5]);
            this.px6y6.BackColor = farbe(labyrinth[6, 6]);
            this.px6y7.BackColor = farbe(labyrinth[6, 7]);
            this.px6y8.BackColor = farbe(labyrinth[6, 8]);
            this.px6y9.BackColor = farbe(labyrinth[6, 9]);
            this.px6y10.BackColor = farbe(labyrinth[6, 10]);
            this.px6y11.BackColor = farbe(labyrinth[6, 11]);
            this.px6y12.BackColor = farbe(labyrinth[6, 12]);
            this.px6y13.BackColor = farbe(labyrinth[6, 13]);
            this.px6y14.BackColor = farbe(labyrinth[6, 14]);
            this.px6y15.BackColor = farbe(labyrinth[6, 15]);
            this.px6y16.BackColor = farbe(labyrinth[6, 16]);
            this.px6y17.BackColor = farbe(labyrinth[6, 17]);
            this.px6y18.BackColor = farbe(labyrinth[6, 18]);
            this.px6y19.BackColor = farbe(labyrinth[6, 19]);
            this.px7y0.BackColor = farbe(labyrinth[7, 0]);
            this.px7y1.BackColor = farbe(labyrinth[7, 1]);
            this.px7y2.BackColor = farbe(labyrinth[7, 2]);
            this.px7y3.BackColor = farbe(labyrinth[7, 3]);
            this.px7y4.BackColor = farbe(labyrinth[7, 4]);
            this.px7y5.BackColor = farbe(labyrinth[7, 5]);
            this.px7y6.BackColor = farbe(labyrinth[7, 6]);
            this.px7y7.BackColor = farbe(labyrinth[7, 7]);
            this.px7y8.BackColor = farbe(labyrinth[7, 8]);
            this.px7y9.BackColor = farbe(labyrinth[7, 9]);
            this.px7y10.BackColor = farbe(labyrinth[7, 10]);
            this.px7y11.BackColor = farbe(labyrinth[7, 11]);
            this.px7y12.BackColor = farbe(labyrinth[7, 12]);
            this.px7y13.BackColor = farbe(labyrinth[7, 13]);
            this.px7y14.BackColor = farbe(labyrinth[7, 14]);
            this.px7y15.BackColor = farbe(labyrinth[7, 15]);
            this.px7y16.BackColor = farbe(labyrinth[7, 16]);
            this.px7y17.BackColor = farbe(labyrinth[7, 17]);
            this.px7y18.BackColor = farbe(labyrinth[7, 18]);
            this.px7y19.BackColor = farbe(labyrinth[7, 19]);
            this.px8y0.BackColor = farbe(labyrinth[8, 0]);
            this.px8y1.BackColor = farbe(labyrinth[8, 1]);
            this.px8y2.BackColor = farbe(labyrinth[8, 2]);
            this.px8y3.BackColor = farbe(labyrinth[8, 3]);
            this.px8y4.BackColor = farbe(labyrinth[8, 4]);
            this.px8y5.BackColor = farbe(labyrinth[8, 5]);
            this.px8y6.BackColor = farbe(labyrinth[8, 6]);
            this.px8y7.BackColor = farbe(labyrinth[8, 7]);
            this.px8y8.BackColor = farbe(labyrinth[8, 8]);
            this.px8y9.BackColor = farbe(labyrinth[8, 9]);
            this.px8y10.BackColor = farbe(labyrinth[8, 10]);
            this.px8y11.BackColor = farbe(labyrinth[8, 11]);
            this.px8y12.BackColor = farbe(labyrinth[8, 12]);
            this.px8y13.BackColor = farbe(labyrinth[8, 13]);
            this.px8y14.BackColor = farbe(labyrinth[8, 14]);
            this.px8y15.BackColor = farbe(labyrinth[8, 15]);
            this.px8y16.BackColor = farbe(labyrinth[8, 16]);
            this.px8y17.BackColor = farbe(labyrinth[8, 17]);
            this.px8y18.BackColor = farbe(labyrinth[8, 18]);
            this.px8y19.BackColor = farbe(labyrinth[8, 19]);
            this.px9y0.BackColor = farbe(labyrinth[9, 0]);
            this.px9y1.BackColor = farbe(labyrinth[9, 1]);
            this.px9y2.BackColor = farbe(labyrinth[9, 2]);
            this.px9y3.BackColor = farbe(labyrinth[9, 3]);
            this.px9y4.BackColor = farbe(labyrinth[9, 4]);
            this.px9y5.BackColor = farbe(labyrinth[9, 5]);
            this.px9y6.BackColor = farbe(labyrinth[9, 6]);
            this.px9y7.BackColor = farbe(labyrinth[9, 7]);
            this.px9y8.BackColor = farbe(labyrinth[9, 8]);
            this.px9y9.BackColor = farbe(labyrinth[9, 9]);
            this.px9y10.BackColor = farbe(labyrinth[9, 10]);
            this.px9y11.BackColor = farbe(labyrinth[9, 11]);
            this.px9y12.BackColor = farbe(labyrinth[9, 12]);
            this.px9y13.BackColor = farbe(labyrinth[9, 13]);
            this.px9y14.BackColor = farbe(labyrinth[9, 14]);
            this.px9y15.BackColor = farbe(labyrinth[9, 15]);
            this.px9y16.BackColor = farbe(labyrinth[9, 16]);
            this.px9y17.BackColor = farbe(labyrinth[9, 17]);
            this.px9y18.BackColor = farbe(labyrinth[9, 18]);
            this.px9y19.BackColor = farbe(labyrinth[9, 19]);
            this.px10y0.BackColor = farbe(labyrinth[10, 0]);
            this.px10y1.BackColor = farbe(labyrinth[10, 1]);
            this.px10y2.BackColor = farbe(labyrinth[10, 2]);
            this.px10y3.BackColor = farbe(labyrinth[10, 3]);
            this.px10y4.BackColor = farbe(labyrinth[10, 4]);
            this.px10y5.BackColor = farbe(labyrinth[10, 5]);
            this.px10y6.BackColor = farbe(labyrinth[10, 6]);
            this.px10y7.BackColor = farbe(labyrinth[10, 7]);
            this.px10y8.BackColor = farbe(labyrinth[10, 8]);
            this.px10y9.BackColor = farbe(labyrinth[10, 9]);
            this.px10y10.BackColor = farbe(labyrinth[10, 10]);
            this.px10y11.BackColor = farbe(labyrinth[10, 11]);
            this.px10y12.BackColor = farbe(labyrinth[10, 12]);
            this.px10y13.BackColor = farbe(labyrinth[10, 13]);
            this.px10y14.BackColor = farbe(labyrinth[10, 14]);
            this.px10y15.BackColor = farbe(labyrinth[10, 15]);
            this.px10y16.BackColor = farbe(labyrinth[10, 16]);
            this.px10y17.BackColor = farbe(labyrinth[10, 17]);
            this.px10y18.BackColor = farbe(labyrinth[10, 18]);
            this.px10y19.BackColor = farbe(labyrinth[10, 19]);
            this.px11y0.BackColor = farbe(labyrinth[11, 0]);
            this.px11y1.BackColor = farbe(labyrinth[11, 1]);
            this.px11y2.BackColor = farbe(labyrinth[11, 2]);
            this.px11y3.BackColor = farbe(labyrinth[11, 3]);
            this.px11y4.BackColor = farbe(labyrinth[11, 4]);
            this.px11y5.BackColor = farbe(labyrinth[11, 5]);
            this.px11y6.BackColor = farbe(labyrinth[11, 6]);
            this.px11y7.BackColor = farbe(labyrinth[11, 7]);
            this.px11y8.BackColor = farbe(labyrinth[11, 8]);
            this.px11y9.BackColor = farbe(labyrinth[11, 9]);
            this.px11y10.BackColor = farbe(labyrinth[11, 10]);
            this.px11y11.BackColor = farbe(labyrinth[11, 11]);
            this.px11y12.BackColor = farbe(labyrinth[11, 12]);
            this.px11y13.BackColor = farbe(labyrinth[11, 13]);
            this.px11y14.BackColor = farbe(labyrinth[11, 14]);
            this.px11y15.BackColor = farbe(labyrinth[11, 15]);
            this.px11y16.BackColor = farbe(labyrinth[11, 16]);
            this.px11y17.BackColor = farbe(labyrinth[11, 17]);
            this.px11y18.BackColor = farbe(labyrinth[11, 18]);
            this.px11y19.BackColor = farbe(labyrinth[11, 19]);
            this.px12y0.BackColor = farbe(labyrinth[12, 0]);
            this.px12y1.BackColor = farbe(labyrinth[12, 1]);
            this.px12y2.BackColor = farbe(labyrinth[12, 2]);
            this.px12y3.BackColor = farbe(labyrinth[12, 3]);
            this.px12y4.BackColor = farbe(labyrinth[12, 4]);
            this.px12y5.BackColor = farbe(labyrinth[12, 5]);
            this.px12y6.BackColor = farbe(labyrinth[12, 6]);
            this.px12y7.BackColor = farbe(labyrinth[12, 7]);
            this.px12y8.BackColor = farbe(labyrinth[12, 8]);
            this.px12y9.BackColor = farbe(labyrinth[12, 9]);
            this.px12y10.BackColor = farbe(labyrinth[12, 10]);
            this.px12y11.BackColor = farbe(labyrinth[12, 11]);
            this.px12y12.BackColor = farbe(labyrinth[12, 12]);
            this.px12y13.BackColor = farbe(labyrinth[12, 13]);
            this.px12y14.BackColor = farbe(labyrinth[12, 14]);
            this.px12y15.BackColor = farbe(labyrinth[12, 15]);
            this.px12y16.BackColor = farbe(labyrinth[12, 16]);
            this.px12y17.BackColor = farbe(labyrinth[12, 17]);
            this.px12y18.BackColor = farbe(labyrinth[12, 18]);
            this.px12y19.BackColor = farbe(labyrinth[12, 19]);
            this.px13y0.BackColor = farbe(labyrinth[13, 0]);
            this.px13y1.BackColor = farbe(labyrinth[13, 1]);
            this.px13y2.BackColor = farbe(labyrinth[13, 2]);
            this.px13y3.BackColor = farbe(labyrinth[13, 3]);
            this.px13y4.BackColor = farbe(labyrinth[13, 4]);
            this.px13y5.BackColor = farbe(labyrinth[13, 5]);
            this.px13y6.BackColor = farbe(labyrinth[13, 6]);
            this.px13y7.BackColor = farbe(labyrinth[13, 7]);
            this.px13y8.BackColor = farbe(labyrinth[13, 8]);
            this.px13y9.BackColor = farbe(labyrinth[13, 9]);
            this.px13y10.BackColor = farbe(labyrinth[13, 10]);
            this.px13y11.BackColor = farbe(labyrinth[13, 11]);
            this.px13y12.BackColor = farbe(labyrinth[13, 12]);
            this.px13y13.BackColor = farbe(labyrinth[13, 13]);
            this.px13y14.BackColor = farbe(labyrinth[13, 14]);
            this.px13y15.BackColor = farbe(labyrinth[13, 15]);
            this.px13y16.BackColor = farbe(labyrinth[13, 16]);
            this.px13y17.BackColor = farbe(labyrinth[13, 17]);
            this.px13y18.BackColor = farbe(labyrinth[13, 18]);
            this.px13y19.BackColor = farbe(labyrinth[13, 19]);
            this.px14y0.BackColor = farbe(labyrinth[14, 0]);
            this.px14y1.BackColor = farbe(labyrinth[14, 1]);
            this.px14y2.BackColor = farbe(labyrinth[14, 2]);
            this.px14y3.BackColor = farbe(labyrinth[14, 3]);
            this.px14y4.BackColor = farbe(labyrinth[14, 4]);
            this.px14y5.BackColor = farbe(labyrinth[14, 5]);
            this.px14y6.BackColor = farbe(labyrinth[14, 6]);
            this.px14y7.BackColor = farbe(labyrinth[14, 7]);
            this.px14y8.BackColor = farbe(labyrinth[14, 8]);
            this.px14y9.BackColor = farbe(labyrinth[14, 9]);
            this.px14y10.BackColor = farbe(labyrinth[14, 10]);
            this.px14y11.BackColor = farbe(labyrinth[14, 11]);
            this.px14y12.BackColor = farbe(labyrinth[14, 12]);
            this.px14y13.BackColor = farbe(labyrinth[14, 13]);
            this.px14y14.BackColor = farbe(labyrinth[14, 14]);
            this.px14y15.BackColor = farbe(labyrinth[14, 15]);
            this.px14y16.BackColor = farbe(labyrinth[14, 16]);
            this.px14y17.BackColor = farbe(labyrinth[14, 17]);
            this.px14y18.BackColor = farbe(labyrinth[14, 18]);
            this.px14y19.BackColor = farbe(labyrinth[14, 19]);
            this.px15y0.BackColor = farbe(labyrinth[15, 0]);
            this.px15y1.BackColor = farbe(labyrinth[15, 1]);
            this.px15y2.BackColor = farbe(labyrinth[15, 2]);
            this.px15y3.BackColor = farbe(labyrinth[15, 3]);
            this.px15y4.BackColor = farbe(labyrinth[15, 4]);
            this.px15y5.BackColor = farbe(labyrinth[15, 5]);
            this.px15y6.BackColor = farbe(labyrinth[15, 6]);
            this.px15y7.BackColor = farbe(labyrinth[15, 7]);
            this.px15y8.BackColor = farbe(labyrinth[15, 8]);
            this.px15y9.BackColor = farbe(labyrinth[15, 9]);
            this.px15y10.BackColor = farbe(labyrinth[15, 10]);
            this.px15y11.BackColor = farbe(labyrinth[15, 11]);
            this.px15y12.BackColor = farbe(labyrinth[15, 12]);
            this.px15y13.BackColor = farbe(labyrinth[15, 13]);
            this.px15y14.BackColor = farbe(labyrinth[15, 14]);
            this.px15y15.BackColor = farbe(labyrinth[15, 15]);
            this.px15y16.BackColor = farbe(labyrinth[15, 16]);
            this.px15y17.BackColor = farbe(labyrinth[15, 17]);
            this.px15y18.BackColor = farbe(labyrinth[15, 18]);
            this.px15y19.BackColor = farbe(labyrinth[15, 19]);
            this.px16y0.BackColor = farbe(labyrinth[16, 0]);
            this.px16y1.BackColor = farbe(labyrinth[16, 1]);
            this.px16y2.BackColor = farbe(labyrinth[16, 2]);
            this.px16y3.BackColor = farbe(labyrinth[16, 3]);
            this.px16y4.BackColor = farbe(labyrinth[16, 4]);
            this.px16y5.BackColor = farbe(labyrinth[16, 5]);
            this.px16y6.BackColor = farbe(labyrinth[16, 6]);
            this.px16y7.BackColor = farbe(labyrinth[16, 7]);
            this.px16y8.BackColor = farbe(labyrinth[16, 8]);
            this.px16y9.BackColor = farbe(labyrinth[16, 9]);
            this.px16y10.BackColor = farbe(labyrinth[16, 10]);
            this.px16y11.BackColor = farbe(labyrinth[16, 11]);
            this.px16y12.BackColor = farbe(labyrinth[16, 12]);
            this.px16y13.BackColor = farbe(labyrinth[16, 13]);
            this.px16y14.BackColor = farbe(labyrinth[16, 14]);
            this.px16y15.BackColor = farbe(labyrinth[16, 15]);
            this.px16y16.BackColor = farbe(labyrinth[16, 16]);
            this.px16y17.BackColor = farbe(labyrinth[16, 17]);
            this.px16y18.BackColor = farbe(labyrinth[16, 18]);
            this.px16y19.BackColor = farbe(labyrinth[16, 19]);
            this.px17y0.BackColor = farbe(labyrinth[17, 0]);
            this.px17y1.BackColor = farbe(labyrinth[17, 1]);
            this.px17y2.BackColor = farbe(labyrinth[17, 2]);
            this.px17y3.BackColor = farbe(labyrinth[17, 3]);
            this.px17y4.BackColor = farbe(labyrinth[17, 4]);
            this.px17y5.BackColor = farbe(labyrinth[17, 5]);
            this.px17y6.BackColor = farbe(labyrinth[17, 6]);
            this.px17y7.BackColor = farbe(labyrinth[17, 7]);
            this.px17y8.BackColor = farbe(labyrinth[17, 8]);
            this.px17y9.BackColor = farbe(labyrinth[17, 9]);
            this.px17y10.BackColor = farbe(labyrinth[17, 10]);
            this.px17y11.BackColor = farbe(labyrinth[17, 11]);
            this.px17y12.BackColor = farbe(labyrinth[17, 12]);
            this.px17y13.BackColor = farbe(labyrinth[17, 13]);
            this.px17y14.BackColor = farbe(labyrinth[17, 14]);
            this.px17y15.BackColor = farbe(labyrinth[17, 15]);
            this.px17y16.BackColor = farbe(labyrinth[17, 16]);
            this.px17y17.BackColor = farbe(labyrinth[17, 17]);
            this.px17y18.BackColor = farbe(labyrinth[17, 18]);
            this.px17y19.BackColor = farbe(labyrinth[17, 19]);
            this.px18y0.BackColor = farbe(labyrinth[18, 0]);
            this.px18y1.BackColor = farbe(labyrinth[18, 1]);
            this.px18y2.BackColor = farbe(labyrinth[18, 2]);
            this.px18y3.BackColor = farbe(labyrinth[18, 3]);
            this.px18y4.BackColor = farbe(labyrinth[18, 4]);
            this.px18y5.BackColor = farbe(labyrinth[18, 5]);
            this.px18y6.BackColor = farbe(labyrinth[18, 6]);
            this.px18y7.BackColor = farbe(labyrinth[18, 7]);
            this.px18y8.BackColor = farbe(labyrinth[18, 8]);
            this.px18y9.BackColor = farbe(labyrinth[18, 9]);
            this.px18y10.BackColor = farbe(labyrinth[18, 10]);
            this.px18y11.BackColor = farbe(labyrinth[18, 11]);
            this.px18y12.BackColor = farbe(labyrinth[18, 12]);
            this.px18y13.BackColor = farbe(labyrinth[18, 13]);
            this.px18y14.BackColor = farbe(labyrinth[18, 14]);
            this.px18y15.BackColor = farbe(labyrinth[18, 15]);
            this.px18y16.BackColor = farbe(labyrinth[18, 16]);
            this.px18y17.BackColor = farbe(labyrinth[18, 17]);
            this.px18y18.BackColor = farbe(labyrinth[18, 18]);
            this.px18y19.BackColor = farbe(labyrinth[18, 19]);
            this.px19y0.BackColor = farbe(labyrinth[19, 0]);
            this.px19y1.BackColor = farbe(labyrinth[19, 1]);
            this.px19y2.BackColor = farbe(labyrinth[19, 2]);
            this.px19y3.BackColor = farbe(labyrinth[19, 3]);
            this.px19y4.BackColor = farbe(labyrinth[19, 4]);
            this.px19y5.BackColor = farbe(labyrinth[19, 5]);
            this.px19y6.BackColor = farbe(labyrinth[19, 6]);
            this.px19y7.BackColor = farbe(labyrinth[19, 7]);
            this.px19y8.BackColor = farbe(labyrinth[19, 8]);
            this.px19y9.BackColor = farbe(labyrinth[19, 9]);
            this.px19y10.BackColor = farbe(labyrinth[19, 10]);
            this.px19y11.BackColor = farbe(labyrinth[19, 11]);
            this.px19y12.BackColor = farbe(labyrinth[19, 12]);
            this.px19y13.BackColor = farbe(labyrinth[19, 13]);
            this.px19y14.BackColor = farbe(labyrinth[19, 14]);
            this.px19y15.BackColor = farbe(labyrinth[19, 15]);
            this.px19y16.BackColor = farbe(labyrinth[19, 16]);
            this.px19y17.BackColor = farbe(labyrinth[19, 17]);
            this.px19y18.BackColor = farbe(labyrinth[19, 18]);
            this.px19y19.BackColor = farbe(labyrinth[19, 19]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (labyrinth[x, y] == 3)
                    {
                        poszx = x;
                        poszy = y;
                    }
                }
            }
            färben();
            labyrinth[poszx, poszy] = 0;
            MessageBox.Show("Zum Starten auf das\nLabyrinth drücken.", "Anleitung");
        }

        public void possetzen()
        {
            this.pfigur.Location = new System.Drawing.Point(posy * 20 + 13 + 4, posx * 20 + 13 + 4);
            Thread.Sleep(500);
        }

        public void bewegen()
        {
            switch (richtung)
            {
                case 'r':
                    if (labyrinth[posx + 1, posy] == 0)
                    {
                        richtung = 'd';
                        posx++;
                    }
                    else
                    {
                        if (labyrinth[posx, posy + 1] == 0)
                        {
                            posy++;
                        }
                        else
                        {
                            richtung = 'u';
                        }
                    }
                    possetzen();
                    break;
                case 'u':
                    if (labyrinth[posx, posy+1] == 0)
                    {
                        richtung = 'r';
                        posy++;
                    }
                    else
                    {
                        if (labyrinth[posx-1, posy] == 0)
                        {
                            posx--;
                        }
                        else
                        {
                            richtung = 'l';
                        }
                    }
                    possetzen();
                    break;
                case 'l':
                    if (labyrinth[posx-1, posy] == 0)
                    {
                        richtung = 'u';
                        posx--;
                    }
                    else
                    {
                        if (labyrinth[posx, posy-1] == 0)
                        {
                            posy--;
                        }
                        else
                        {
                            richtung = 'd';
                        }
                    }
                    possetzen();
                    break;
                case 'd':
                    if (labyrinth[posx, posy-1] == 0)
                    {
                        richtung = 'l';
                        posy--;
                    }
                    else
                    {
                        if (labyrinth[posx+1, posy] == 0)
                        {
                            posx++;
                        }
                        else
                        {
                            richtung = 'r';
                        }
                    }
                    possetzen();
                    break;
            }

        }

        public void start()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (labyrinth[x, y] == 2)
                    {
                        posx = x;
                        posy = y;
                    }
                }
            }
            this.pfigur.Visible = true;
            possetzen();
            Boolean ziel = false;
            while (ziel == false)
            {
                bewegen();
                if (posx == poszx && posy == poszy)
                {
                    ziel = true;
                }
            }
            MessageBox.Show("Labyrinth erfolgreich durchlaufen!", "Gratulation");
        }

        private void px0y0_MouseClick(object sender, MouseEventArgs e)
        {
            start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Dieses Programm wurde dir Präsentiert von:\n\n  - Angela Krieger\n  - Patrik Suter", "Impressum");
        }
    }
}
