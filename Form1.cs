using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Class_Assignment_Week_8
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        
        public static string sqlConnection = "server = ;uid=;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable dtManager = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtTeam = new DataTable();

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtManager.Clear();
            dtPlayer.Clear();
            cBoxTeamName.Visible = true;
            btnSearchTeam.Visible = true;
            dgvManager.Visible = true;
            dgvPlayer.Visible = true;
            dgvMatch.Visible = false;
            btnSearchMatch.Visible = false;

            sqlQuery = "select * from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTeamName.DataSource = dtTeam;
            cBoxTeamName.DisplayMember = "team_name";
            cBoxTeamName.ValueMember = "team_id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtManager.Clear();
            dtPlayer.Clear();
            sqlQuery = $"select t.team_name as `Team Name`, m.manager_name as `Manager Name`, m.birthdate as `Birthday`, n.nation as `Nationality` from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '{cBoxTeamName.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);
            dgvManager.DataSource = dtManager;

            sqlQuery = $"select p.player_name as `Player Name`, t.team_name as `Team Name`, p.playing_pos as `Position`, p.height as `Height`, p.weight as `Weight` from player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id and t.team_id = '{cBoxTeamName.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvPlayer.DataSource = dtPlayer;
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cBoxTeamName.Visible = true;
            btnSearchMatch.Visible = true;
            dgvMatch.Visible = true;
            dgvManager.Visible = false;
            dgvPlayer.Visible = false;
            
            sqlQuery = "select * from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTeamName.DataSource = dtTeam;
            cBoxTeamName.DisplayMember = "team_name";
            cBoxTeamName.ValueMember = "team_id";
        }

        private void btnSearchMatch_Click(object sender, EventArgs e)
        {
            dtMatch.Clear();
            sqlQuery = $"select t.team_name as `Team Home`, t1.team_name as `Team Away`, m.match_date as `Match Date`, m.goal_home as `Goal Home`, m.goal_away as `Goal Away`, r.referee_name as `Referee Name` from `match` m, team t, referee r, team t1 where m.referee_id = r.referee_id and m.team_home = t.team_id and m.team_away = t1.team_id and (t.team_id = '{cBoxTeamName.SelectedValue.ToString()}' or t1.team_id = '{cBoxTeamName.SelectedValue.ToString()}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgvMatch.DataSource = dtMatch;
        }
    }
}
