using DataAccess.ExceptionModels;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;
using DuelSysLogic.Models.Tournament.Tournament_Systems;
using DuelSysLogic.Models.Tournament.TournamentDetails;
using DuelSysLogic.Models.TournamentModels;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DuelSysDesktop.UserControlsTournamentManagement
{
    public partial class UCCreateTournament : UserControl
    {
        private const int PAGENUMBERONE = 1;
        private Association association;
        private UCViewTournaments ucViewTournaments;

        private Dictionary<string, ITournamentSystem> tournamentSystems;
        private Dictionary<string, Sport> sportsType;

        public UCCreateTournament()
        {
            InitializeComponent();
        }

        internal void Setup(Association association, UCViewTournaments uCViewTournaments)
        {
            this.ucViewTournaments = uCViewTournaments;
            this.association = association;

            
            dtpStartDate.MinDate = DateTime.Now.Date;
            dtpEndDate.MinDate = DateTime.Now.Date;

            settingcbSportTypes();
            fillcbTournamentSystem();

            void settingcbSportTypes() 
            {
                this.sportsType = new Dictionary<string, Sport>();

                this.sportsType.Add("Badminton",new Badminton());
                this.sportsType.Add("Ping Pong", new PingPong());

                for (int i = 0; i<sportsType.Keys.Count;i++) 
                {
                    cbSportType.Items.Add(sportsType.ToList()[i].Key.ToString());
                }
            }

            void fillcbTournamentSystem() 
            {
                this.tournamentSystems = new Dictionary<string, ITournamentSystem>();

                this.tournamentSystems.Add("Round Robin", new RoundRobin());

                for (int i = 0; i < tournamentSystems.Keys.Count; i++)
                {
                    cbTournamentSystem.Items.Add(tournamentSystems.ToList()[i].Key.ToString());
                }
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> warningFields = new List<string>();
                List<string> requiredFields = new List<string>();

                string title = tbTitle.Text;
                string description = tbDescription.Text;


                string sportTypeInString = cbSportType.Text;
                string tournamentSystemInString = cbTournamentSystem.Text;

                int minPlayers = (int)nudMinPlayers.Value;
                int maxPlayers = (int)nudMaxPlayers.Value;

                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                string street = tbStreet.Text;
                string zipcode = tbZipcode.Text;
                string buildingNum = tbBuidlingNum.Text;

                if (string.IsNullOrEmpty(title))
                {
                    requiredFields.Add("Title is missing");

                }
                if (string.IsNullOrEmpty(description))
                {
                    requiredFields.Add("Description is missing");
                }

                if (string.IsNullOrEmpty(sportTypeInString))
                {
                    requiredFields.Add("Sport type is missing");
                }
                if (string.IsNullOrEmpty(tournamentSystemInString))
                {
                    requiredFields.Add("Tournament system is missing");
                }

                if (minPlayers == 0)
                {
                    requiredFields.Add("Minimum players is 0");
                }
                if (maxPlayers == 0)
                {
                    requiredFields.Add("Maximum players is 0");
                }
                else if(maxPlayers > 64)
                {
                    requiredFields.Add("Maximum teams can't be 64 for round robin");
                }

                if (startDate == DateTime.Today)
                {
                    warningFields.Add("Start date is today");
                }
                if (endDate == DateTime.Today)
                {
                    warningFields.Add("End date is today");
                }

                if (string.IsNullOrEmpty(street))
                {
                    requiredFields.Add("Street is missing");
                }
                if (string.IsNullOrEmpty(buildingNum))
                {
                    requiredFields.Add("Building number is missing");
                }
                if (string.IsNullOrEmpty(zipcode))
                {
                    requiredFields.Add("Zipcode is missing");
                }


                if (!Regex.IsMatch(title, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{1,40}$") && !string.IsNullOrWhiteSpace(title))
                {
                    requiredFields.Add("Title should be at least 2 digits and maximum 40 digits");
                }
                if (!Regex.IsMatch(description, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{3,255}$") && !string.IsNullOrWhiteSpace(description))
                {
                    requiredFields.Add("Description should be at least 4 digits and maximum 255 digits");
                }
                if (!Regex.IsMatch(street, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,50}$") && !string.IsNullOrWhiteSpace(street))
                {
                    requiredFields.Add("Street should be at least 2 digits and maximum 50 digits");
                }
                if (!Regex.IsMatch(buildingNum, @"^\d{1,3}$") && !string.IsNullOrWhiteSpace(buildingNum))
                {
                    requiredFields.Add("Buidling number should be number");
                }
                if (!Regex.IsMatch(zipcode, @"^\d{4}\s?([A-Z]{2})?$") && !string.IsNullOrWhiteSpace(zipcode))
                {
                    requiredFields.Add("Zipcode should be valid");
                }

                if (requiredFields.Count == 0)
                {
                    if (warningFields.Count != 0) 
                    {
                        string warningStr = string.Empty;

                        foreach (var warning in warningFields)
                        {
                            warningStr += warning + Environment.NewLine;
                        }
                        var result = MessageBox.Show($"Are you you want to create {Environment.NewLine}?" + warningStr, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.No) 
                        {
                            return;
                        }
                    }

                    ITournamentSystem tournamentSystem = tournamentSystems[tournamentSystemInString];
                    Sport sportType = sportsType[sportTypeInString];

                    TournamentShortInfo tournamentShortInfo = new TournamentShortInfo(title, tournamentSystem, sportType);

                    Requirement requirement = new Requirement(minPlayers, maxPlayers);

                    Location location = new Location(street, buildingNum, zipcode);

                    Tournament newTournament = new Tournament(tournamentShortInfo, description, location, requirement, startDate, endDate);

                    var dialogResult = MessageBox.Show($"Title: {newTournament.TournamentShortInfo.Title}{Environment.NewLine}" +
                        $"Description: {newTournament.Description}{Environment.NewLine}" +
                        $"Sport Type: {newTournament.TournamentShortInfo.SportType.ToString()}{Environment.NewLine}" +
                        $"Tournament System: {newTournament.TournamentShortInfo.TournamentSystem.ToString()}{Environment.NewLine}" +
                        $"Minimum players: {newTournament.Requirement.MinPlayers}{Environment.NewLine}" +
                        $"Maximum players: {newTournament.Requirement.MaxPlayers}{Environment.NewLine}" +
                        $"Duration: {newTournament.StartDate.ToString("dd/MM/yyyy")} till {newTournament.EndDate.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
                        $"Street: {newTournament.Location.Street}{Environment.NewLine}" +
                        $"Building number: {newTournament.Location.BuidlingNum}{Environment.NewLine}" +
                        $"Zipcode: {newTournament.Location.ZipCode}{Environment.NewLine}", "Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No) 
                    {
                        return;
                    }
                    
                    association.CreateTournament(newTournament);

                    MessageBox.Show("Tournament created successfully");
                    cleanCreateTournamentUserControl();
                    this.Hide();
                    ucViewTournaments.Show();

                    ucViewTournaments.RefreshDGVViewTournaments(PAGENUMBERONE);
                }
                else 
                {
                    string requiredStr = string.Empty;

                    foreach (var required in requiredFields) 
                    {
                        requiredStr += required + Environment.NewLine;
                    }

                    MessageBox.Show(requiredStr,"Missing fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (UnableToConnectToHostException ex)
            {
                MessageBox.Show(ex.Message + ", Please make sure that you are connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DALException ex)
            {
                MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ucViewTournaments.Show();
        }

        private void nudMinPlayers_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxPlayers.Value < nudMinPlayers.Value)
            {
                nudMaxPlayers.Value++;
            }    
        }

        private void nudMaxPlayers_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxPlayers.Value == nudMinPlayers.Value && nudMinPlayers.Value != 3) 
            {
                nudMinPlayers.Value--;
            }
            if (cbTournamentSystem.Text == "Round Robin" && nudMaxPlayers.Value > 64)
            {
                nudMaxPlayers.Value--;
                MessageBox.Show("You can't generate round robin tournament with more than 64 teams", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cleanCreateTournamentUserControl() 
        {
            tbTitle.Text = String.Empty;
            tbDescription.Text = String.Empty;

            cbSportType.SelectedItem = null;
            cbTournamentSystem.SelectedItem = null;

            nudMinPlayers.Value = nudMinPlayers.Minimum;
            nudMaxPlayers.Value = nudMaxPlayers.Minimum;

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            tbStreet.Text = String.Empty;
            tbBuidlingNum.Text = String.Empty;  
            tbZipcode.Text = String.Empty;

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;

            if (startDate > dtpEndDate.Value)
            {
                dtpEndDate.Value = new DateTime(startDate.Year, startDate.Month, startDate.Day);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = dtpEndDate.Value;

            if (endDate < dtpStartDate.Value)
            {
                dtpStartDate.Value = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            }
        }

    }
}
