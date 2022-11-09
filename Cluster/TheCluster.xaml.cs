using RR.Intilization;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RR.ui;
using RR.Properties;
using System.Windows.Threading;
using RR.ui.conts;
using RR.Dataplane;
using RR.Dataplane.NOS;
using RR.Comuting.computing;
using RR.NetAnimator;
using RR.Comuting.Routing;
using RR.Comuting.SinkClustering;
using RR.RingRouting;
using RR.Models.Energy;
using MP.MergedPath.Routing;

namespace RR.Cluster
{
    /// <summary>
    /// Interaction logic for Cluster.xaml
    /// </summary>
    public partial class TheCluster : UserControl
    {
        private double clusterHeight { get; set; }
        private double clusterWidth {get; set; }
        public Point clusterLocMargin { get; set; }
        public Point clusterCenterComputed { get; set; }
        public Point clusterCenterMargin { get; set; }
        public Point clusterActualCenter { get; set; }
        public int ID { set; get; }
        public List<Sensor> clusterNodes = new List<Sensor>();
        public bool isVisited = false;
        public Sensor CellHeader { get; set; }

        public TheCluster()
        {

        }
        public TheCluster(Point locatio, int id, double Height, double width)
        {
            InitializeComponent();
            ID = id;
            clusterLocMargin = locatio;
            clusterHeight = Height;
            clusterWidth = width;
        }

        public void setPositionOnWindow()
        {
            //Setting the height and widths of each cluster and its container
            ell_clust.Height = clusterHeight;
            ell_clust.Width = clusterWidth;
            canv_cluster.Height = clusterHeight;
            canv_cluster.Width = clusterWidth;

            //Giving a margin for each cluster container
            Thickness clusterMargin = canv_cluster.Margin;
            clusterMargin.Top = this.clusterLocMargin.Y;
            clusterMargin.Left = this.clusterLocMargin.X;
            canv_cluster.Margin = clusterMargin;
            //Giving a margin for each cluster center (Margin inside the container)

        }
        public int getID()
        {
            return this.ID;
        }
        public List<Sensor> getClusterNodes()
        {
            return clusterNodes;
        }
       

        

    }
}
