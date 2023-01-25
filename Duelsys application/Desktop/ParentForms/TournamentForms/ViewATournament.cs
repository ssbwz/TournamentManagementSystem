using DataAccess.ExceptionModels;
using System.Text.RegularExpressions;
using DuelSysDesktop.ParentForms.TournamentForms;
using DuelSysDesktop.UserControlsTournamentManagement;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;
using DuelSysLogic.Models.Tournament.Tournament_Systems;
using DuelSysLogic.Models.Tournament.TournamentDetails;
using DuelSysLogic.Models.TournamentModels;
using System.Diagnostics;
using DataAccess.TournamentManagement;
using DuelSysLogic.Managers.TournamentManager;
using DuelSysLogic.Exceptions.TouranmentsSystems;
using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.TournamentFroms
{
    public partial class ViewATournament : Form
    {
        
        private Tournament selectedTournament;

        private UCViewTournaments uCViewTournament;
        private Association association;
        private Dictionary<string, ITournamentSystem> tournamentSystems;
        private Dictionary<string, Sport> sportsType;


        //Schedule tab
        private int pageNumber;
        private const int PAGE_NUMBER_ONE = 1;

        private List<DuelSys_Logic.Models.TournamentModels.Match> matches;

        public ViewATournament(Association association, Tournament selectedtournament, UCViewTournaments uCViewTournament)
        {
            InitializeComponent();
            DesignClass.AutoDesginerForForms(this.Controls, this);

            this.selectedTournament = selectedtournament;
            this.uCViewTournament = uCViewTournament;
            this.association = association;

            settingcbSportTypes();
            fillcbTournamentSystem();
            intializeDGVViewMatches();

            setFields();
            refreshDGVMatches(PAGE_NUMBER_ONE);

            if (matches == null)
            {
                DGVViewMatches.Hide();
                NUDPages.Hide();
                lbPageNumber.Hide();
            }
            else
            {
                lbThereAreNoSchedule.Hide();
                btGenerateSchedule.Hide();
            }
            if(!selectedTournament.IsDone) 
            {
                TournamentTabs.TabPages.Remove(tpOverview);
            }
            else 
            {
                GenerateOverView();
            }

            void setFields()
            {
                tbTitle.Text = selectedTournament.TournamentShortInfo.Title;
                tbDescription.Text = selectedTournament.Description;

                cbSportType.SelectedItem = selectedTournament.TournamentShortInfo.SportType.ToString();
                cbTournamentSystem.SelectedItem = selectedTournament.TournamentShortInfo.TournamentSystem.ToString();

                nudMaxPlayers.Value = selectedTournament.Requirement.MaxPlayers;
                nudMinPlayers.Value = selectedTournament.Requirement.MinPlayers;

                dtpStartDate.Value = selectedTournament.StartDate;
                dtpEndDate.Value = selectedTournament.EndDate;

                tbStreet.Text = selectedTournament.Location.Street;
                tbBuidlingNum.Text = selectedTournament.Location.BuidlingNum;
                tbZipcode.Text = selectedTournament.Location.ZipCode;
            }

            void settingcbSportTypes()
            {
                this.sportsType = new Dictionary<string, Sport>();

                this.sportsType.Add("Badminton", new Badminton());
                this.sportsType.Add("Ping Pong", new PingPong());

                for (int i = 0; i < sportsType.Keys.Count; i++)
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

            void intializeDGVViewMatches()
            {
                DGVViewMatches.Columns.Add("Match", "Match");
                DGVViewMatches.Columns["Match"].Visible = false;
                DGVViewMatches.Columns.Add("Match Id", "Match Id");
                DGVViewMatches.Columns.Add("Team Away", "Team Away");
                DGVViewMatches.Columns.Add("Team Home", "Team Home");
                DGVViewMatches.Columns.Add("Match Result", "Match Result");
            }
        }

        //Tournament Info tab

        private void btnSave_Click(object sender, EventArgs e)
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
                else if (maxPlayers > 64)
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

                    TournamentShortInfo tournamentShortInfo = new TournamentShortInfo(selectedTournament.TournamentShortInfo.Id, title, tournamentSystem, sportType);

                    Requirement requirement = new Requirement(minPlayers, maxPlayers);

                    Location location = new Location(street, buildingNum, zipcode);

                    Tournament updatedTournament = new Tournament(tournamentShortInfo, description, location, requirement, startDate, endDate);

                    var dialogResult = MessageBox.Show($"Title: {updatedTournament.TournamentShortInfo.Title}{Environment.NewLine}" +
                        $"Description: {updatedTournament.Description}{Environment.NewLine}" +
                        $"Sport Type: {updatedTournament.TournamentShortInfo.SportType.ToString()}{Environment.NewLine}" +
                        $"Tournament System: {updatedTournament.TournamentShortInfo.TournamentSystem.ToString()}{Environment.NewLine}" +
                        $"Minimum players: {updatedTournament.Requirement.MinPlayers}{Environment.NewLine}" +
                        $"Maximum players: {updatedTournament.Requirement.MaxPlayers}{Environment.NewLine}" +
                        $"Duration: {updatedTournament.StartDate.ToString("dd/MM/yyyy")} till {updatedTournament.EndDate.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
                        $"Street: {updatedTournament.Location.Street}{Environment.NewLine}" +
                        $"Building number: {updatedTournament.Location.BuidlingNum}{Environment.NewLine}" +
                        $"Zipcode: {updatedTournament.Location.ZipCode}{Environment.NewLine}", "Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    association.UpdateTournament(updatedTournament);

                    MessageBox.Show("Changes got saved successfully");

                    uCViewTournament.RefreshDGVViewTournaments(PAGE_NUMBER_ONE);
                }
                else
                {
                    string requiredStr = string.Empty;

                    foreach (var required in requiredFields)
                    {
                        requiredStr += required + Environment.NewLine;
                    }

                    MessageBox.Show(requiredStr, "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void nudMinPlayers_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxPlayers.Value < nudMinPlayers.Value)
            {
                nudMaxPlayers.Value++;
            }
        }

        private void nudMaxPlayers_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxPlayers.Value == nudMinPlayers.Value && nudMinPlayers.Value != 0)
            {
                nudMinPlayers.Value--;
            }
            if (cbTournamentSystem.Text == "Round Robin" && nudMaxPlayers.Value > 64) 
            {
                nudMaxPlayers.Value--;
                MessageBox.Show("You can't generate round robin tournament with more than 64 teams", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Schedule tab

        private void refreshDGVMatches(int pageNumber)
        {
            try
            {
                if (pageNumber < 0)
                {
                    return;
                }

                DGVViewMatches.Rows.Clear();

                matches = selectedTournament.GetTwelveMatchesPerPage(pageNumber);

                NUDPages.Value = pageNumber;
                printMatches();
            }
            catch (DALException ex)
            {
                throw new DALException(ex.Message, ex);
            }
            catch (UnableToConnectToHostException ex)
            {
                throw new UnableToConnectToHostException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void printMatches()
        {
            if (matches == null)
            {
                return;
            }
            foreach (var match in matches)
            {

                DGVViewMatches.Rows.Add(match, match.Id,match.TeamAway == null? "Bye": match.TeamAway.Name, match.TeamHome == null ? "Bye" : match.TeamHome.Name, match.MatchResult);
            }
        }

        internal void RefreshDGVMatches()
        {
            try
            {
                pageNumber = (int)NUDPages.Value;

                DGVViewMatches.Rows.Clear();

                matches = selectedTournament.GetTwelveMatchesPerPage(pageNumber);


                printMatches();
            }
            catch (DALException ex)
            {
                throw new DALException(ex.Message, ex);
            }
            catch (UnableToConnectToHostException ex)
            {
                throw new UnableToConnectToHostException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void NUDPages_ValueChanged(object sender, EventArgs e)
        {
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
            pageNumber = (int)NUDPages.Value;
            refreshDGVMatches(pageNumber);

            if (matches == null)
            {
                --NUDPages.Value;
            }

            if (matches.Count < 8 && pageNumber > 1)
            {
                --NUDPages.Value;
                return;
            }
            refreshDGVMatches(pageNumber);
            return;
        }

        private void DGVViewMatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DuelSys_Logic.Models.TournamentModels.Match match = getSelectedMatch();
            if (match.TeamAway == null || match.TeamHome == null) 
            {
                MessageBox.Show("You can't register results in match that has one team", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RegisterResults registerResults = new RegisterResults(match, selectedTournament, this);
            registerResults.ShowDialog();
        }

        private DuelSys_Logic.Models.TournamentModels.Match getSelectedMatch()
        {
            int selectedIndex = DGVViewMatches.CurrentRow.Index;
            return (DuelSys_Logic.Models.TournamentModels.Match)DGVViewMatches.Rows[selectedIndex].Cells["Match"].Value;
        }

        private void btGenerateSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                List<Team> participants = null;
                try
                {
                    participants = selectedTournament.GetParticipants();
                }
                catch (UnableToConnectToHostException ex)
                {
                    MessageBox.Show(ex.Message + ", Please make sure that you are connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (DALException ex)
                {
                    MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (selectedTournament.Requirement.MinPlayers <= participants.Count)
                {
                    if (selectedTournament.StartDate < DateTime.Now.AddDays(7))
                    {
                        var reuslt = MessageBox.Show("The tournament start after one week are you sure you want to create schedule?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (reuslt == DialogResult.No)
                        {
                            return;
                        }
                    }
                        matches = selectedTournament.TournamentShortInfo.TournamentSystem.GenerateSchedule(participants);
                                   

                    try
                    {
                        selectedTournament.InsertMatches(matches);
                    }
                    catch (UnableToConnectToHostException ex)
                    {
                        MessageBox.Show(ex.Message + ", Please make sure that you are connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (DALException ex)
                    {
                        MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    showGeneratedMatches();
                }
                else
                {
                    MessageBox.Show("The tournament doesn't match minimum requirement", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
                return;
            }

            void showGeneratedMatches() 
            {
                DGVViewMatches.Show();
                NUDPages.Show();
                lbPageNumber.Show();
                lbThereAreNoSchedule.Hide();
                btGenerateSchedule.Hide();
                refreshDGVMatches(PAGE_NUMBER_ONE);
            }
        }

        //Overview tab
        internal void GenerateOverView() 
        {
            try
            {
                if (!selectedTournament.IsDone)
                {
                    return;
                }

                refreshDGVMatches(PAGE_NUMBER_ONE);
                try
                {
                    fillingFieldsOveriew();
                }
                catch (HandleTiesException ex)
                {
                    MessageBox.Show(ex.Message , "Tournament", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!TournamentTabs.TabPages.Contains(tpOverview))
                {
                    TournamentTabs.TabPages.Add(tpOverview);
                }

                void fillingFieldsOveriew()
                {
                    lbSportType.Text = "Sport: " + selectedTournament.TournamentShortInfo.SportType.ToString();
                    lbTournamentSystem.Text = "Tournament system: " + selectedTournament.TournamentShortInfo.TournamentSystem.ToString();
                    lbStreet.Text = "Street: " + selectedTournament.Location.Street;

                    lbStartDate.Text = "Start Date: " + selectedTournament.StartDate.ToString("dd/MM/yyyy");
                    lbEndDate.Text = "End Date: " + selectedTournament.EndDate.ToString("dd/MM/yyyy");

                    lbGold.Text = "Gold: " + selectedTournament.GoldenMedalTeam.Name;
                    lbSilver.Text = "Silver: " + selectedTournament.SilverMedalTeam.Name;
                    lbBronze.Text = "Bronze: " + selectedTournament.BronzeMedalTeam.Name;

                    fillingParticipantsDGV();
                    fillingFinalMatchesDGV();

                    void fillingParticipantsDGV()
                    {
                        if (DGVParticipants.Columns.Count == 0)
                        {
                            DGVParticipants.Columns.Add("Team", "Team");
                            DGVParticipants.Columns["Team"].Visible = false;
                            DGVParticipants.Columns.Add("Id", "#");
                            DGVParticipants.Columns.Add("Team name", "Team name");
                        }

                        DGVParticipants.Rows.Clear();
                        foreach (Team team in selectedTournament.GetParticipants())
                        {
                            DGVParticipants.Rows.Add(team, team.Id, team.Name);
                        }
                    }
                    void fillingFinalMatchesDGV()
                    {
                        if (DGVFinalMatches.Columns.Count == 0)
                        {
                            DGVFinalMatches.Columns.Add("Match", "Match");
                            DGVFinalMatches.Columns["Match"].Visible = false;
                            DGVFinalMatches.Columns.Add("Id", "#");
                            DGVFinalMatches.Columns.Add("Team Away", "Team Away");
                            DGVFinalMatches.Columns.Add("Team Home", "Team Home");
                            DGVFinalMatches.Columns.Add("Match Result", "Match Result");
                        }

                        DGVFinalMatches.Rows.Clear();
                        foreach (DuelSys_Logic.Models.TournamentModels.Match match in matches)
                        {
                            if (match.TeamHome != null && match.TeamAway != null)
                            {
                                DGVFinalMatches.Rows.Add(match, match.Id, match.TeamAway.Name, match.TeamHome.Name, match.MatchResult);
                            }
                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                if (TournamentTabs.TabPages.Contains(tpOverview))
                {
                    TournamentTabs.TabPages.Remove(tpOverview);
                }
                throw new Exception(ex.Message,ex);
            }
        }

        internal void DetermineTournamentWinners()
        {
            if (!selectedTournament.IsDone) 
            {
                return;
            }
            List<Team> topTeams = TiesHandler.GetTopThree(matches);

            selectedTournament.GoldenMedalTeam = topTeams[0];
            selectedTournament.SilverMedalTeam = topTeams[1];
            selectedTournament.BronzeMedalTeam = topTeams[2];

            association.UpdateMedals(selectedTournament);
        }
    }
}
