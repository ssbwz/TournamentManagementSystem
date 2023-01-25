

using DataAccess.ExceptionModels;
using DuelSys_Logic.Models.TournamentModels;
using DuelSysDesktop.ParentForms.TournamentFroms;
using DuelSysLogic.Exceptions;
using DuelSysLogic.Models.TournamentModels;
using MediaBazaar.Design;
using System.Diagnostics;

namespace DuelSysDesktop.ParentForms.TournamentForms
{
    public partial class RegisterResults : Form
    {
        private Tournament tournament;
        private Match match;
        private ViewATournament viewATournamentform;

        public RegisterResults(Match match,Tournament tournament,ViewATournament viewATournamentform)
        {
            try
            {
                InitializeComponent();
                DesignClass.AutoDesginerForForms(this.Controls, this);

                this.tournament = tournament;
                this.match = match;

                this.viewATournamentform = viewATournamentform;

                fillFields();

                void fillFields()
                {
                    this.Text = $"{match.TeamAway.Name} VS {match.TeamHome.Name}";
                    lbMatchId.Text += match.Id.ToString();
                    lbTeamAway.Text = $"{match.TeamAway.Name}({match.TeamAway.Id})";
                    lbTeamHome.Text = $"{match.TeamHome.Name}({match.TeamHome.Id})";
                }
            }
            catch (Exception ex) 
            {
                this.Hide();
                Debug.WriteLine(ex);
                MessageBox.Show("Something went wrong when openging register form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btRegisterResult_Click(object sender, EventArgs e)
        {
            try
            {
                match.ScoreTeamAway = Convert.ToInt32(tbTeamAwayScore.Text);
                match.ScoreTeamHome = Convert.ToInt32(tbTeamHomeScore.Text);

                tournament.RegisterResults(match);

                this.Hide();
                MessageBox.Show("Results got registered successfully", "Registered results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewATournamentform.RefreshDGVMatches();
                viewATournamentform.DetermineTournamentWinners();
                viewATournamentform.GenerateOverView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check the score format", "Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WrongScoringException ex)
            {
                MessageBox.Show(ex.Message + ", Please make sure that you are following the scoring system of the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SettingWinnerException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
