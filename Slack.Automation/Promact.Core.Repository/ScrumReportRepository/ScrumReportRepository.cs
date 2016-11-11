﻿using Promact.Core.Repository.ProjectUserCall;
using Promact.Erp.DomainModel.ApplicationClass;
using Promact.Erp.DomainModel.DataRepository;
using Promact.Erp.DomainModel.Models;
using Promact.Erp.Util.StringConstants;
using Promact.Erp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promact.Core.Repository.ScrumReportRepository
{
    public class ScrumReportRepository : IScrumReportRepository
    {
        #region Private Variables
        private readonly IRepository<Scrum> _scrumDataRepository;
        private readonly IRepository<ScrumAnswer> _scrumAnswerDataRepository;
        private readonly IProjectUserCallRepository _projectUserCallRepository;
        private readonly IStringConstantRepository _stringConstant;
        #endregion

        #region Constructor
        public ScrumReportRepository(IRepository<Scrum> scrumDataRepository, IRepository<ScrumAnswer> scrumAnswerDataRepository, IStringConstantRepository stringConstant, IProjectUserCallRepository projectUserCallRepository)
        {
            _scrumDataRepository = scrumDataRepository;
            _scrumAnswerDataRepository = scrumAnswerDataRepository;
            _projectUserCallRepository = projectUserCallRepository;
            _stringConstant = stringConstant;
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Method to return list of employees in the project with their scrum answers based on role of logged in user
        /// </summary>
        /// <param name="project"></param>
        /// <param name="scrum"></param>
        /// <param name="loginUser"></param>
        /// <param name="scrumDate"></param>
        /// <returns>Object with list of employees in project with answers to scrum questions</returns>
        private IList<EmployeeScrumDetails> GetEmployeeScrumDetails(ProjectAc project, Scrum scrum, User loginUser, DateTime scrumDate)
        {
            List<EmployeeScrumDetails> employeeScrumDetails = new List<EmployeeScrumDetails>();
            //Assigning answers of scrum to employees in the project based on their role
            //If logged user is an employee it will return only his scrum answers
            if (loginUser.Role.Equals(_stringConstant.Employee))
            {
                foreach (var user in project.ApplicationUsers)
                {
                    if (user.Id.Equals(loginUser.Id))
                    {
                        EmployeeScrumDetails employeeScrumDetail = AssignAnswers(scrum, scrumDate, user);
                        employeeScrumDetails.Add(employeeScrumDetail);
                    }
                }
            }
            //If logged user is admin or teamleader it will return scrum answers for the entire team
            else
            {
                foreach (var user in project.ApplicationUsers)
                {
                    EmployeeScrumDetails employeeScrumDetail = AssignAnswers(scrum, scrumDate, user);
                    employeeScrumDetails.Add(employeeScrumDetail);
                }
            }
            return employeeScrumDetails;
        }


        /// <summary>
        /// Method to assign scrum answers for a specific date to a particular employee
        /// </summary>
        /// <param name="scrum"></param>
        /// <param name="scrumDate"></param>
        /// <param name="user"></param>
        /// <returns>object with scrum answers for an employee</returns>
        private EmployeeScrumDetails AssignAnswers(Scrum scrum, DateTime scrumDate, User user)
        {
            EmployeeScrumDetails employeeScrumDetail = new EmployeeScrumDetails();
            //Fetch all the scrum answers for a particular employee
            List<ScrumAnswer> scrumAnswers = _scrumAnswerDataRepository.Fetch(x => x.EmployeeId == user.Id).ToList();
            //Find scrum answers for a particular employee of a particular project on a specific date 
            List<ScrumAnswer> todayScrumAnswers = scrumAnswers.FindAll(x => x.AnswerDate == scrumDate && x.ScrumId == scrum.Id).ToList();
            employeeScrumDetail.EmployeeName = string.Format("{0} {1}", user.FirstName, user.LastName);
            //Assigning answers to specific scrum questions
            if (todayScrumAnswers.Count() == 0)
            {
                employeeScrumDetail.Status = _stringConstant.PersonNotAvailable;
            }
            foreach (var todayScrumAnswer in todayScrumAnswers)
            {
                if (todayScrumAnswer.Question.QuestionStatement.Equals(_stringConstant.ScrumFirstQuestion))
                {
                    employeeScrumDetail.Answer1 = todayScrumAnswer.Answer.Split('\n');
                }
                if (todayScrumAnswer.Question.QuestionStatement.Equals(_stringConstant.ScrumSecondQuestion))
                {
                    employeeScrumDetail.Answer2 = todayScrumAnswer.Answer.Split('\n');
                }
                if (todayScrumAnswer.Question.QuestionStatement.Equals(_stringConstant.ScrumThirdQuestion))
                {
                    employeeScrumDetail.Answer3 = todayScrumAnswer.Answer.Split('\n');
                }
            }
            return employeeScrumDetail;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Method to return the list of projects depending on the role of the logged in user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="accessToken"></param>
        /// <returns>List of projects</returns>
        public async Task<IEnumerable<ProjectAc>> GetProjects(string userName, string accessToken)
        {
            //Getting the details of the logged in user from Oauth server
            User loginUser = await _projectUserCallRepository.GetUserByUserName(userName, accessToken);
            //Fetch list of all the projects from oauth server
            List<ProjectAc> projects = await _projectUserCallRepository.GetAllProjects(accessToken);

            //Returning list of projects as per the role of the loggeed in user
            if (loginUser.Role.Equals(_stringConstant.Admin))
            {
                return projects;
            }

            else if (loginUser.Role.Equals(_stringConstant.Employee))
            {
                List<ProjectAc> employeeProjects = new List<ProjectAc>();
                foreach (var project in projects)
                {
                    foreach (var user in project.ApplicationUsers)
                    {
                        if (user.Id == loginUser.Id)
                        {
                            employeeProjects.Add(project);
                        }
                    }
                }
                return employeeProjects;
            }

            if (loginUser.Role.Equals(_stringConstant.TeamLeader))
            {
                List<ProjectAc> leaderProjects = projects.FindAll(x => x.TeamLeaderId == loginUser.Id).ToList();
                return leaderProjects;
            }
            return null;
        }


        /// <summary>
        /// Method to return the details of scrum for a particular project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="scrumDate"></param>
        /// <param name="userName"></param>
        /// <param name="accessToken"></param>
        /// <returns>Details of the scrum</returns>
        public async Task<ScrumProjectDetails> ScrumReportDetails(int projectId, DateTime scrumDate,string userName, string accessToken)
        {
            //Getting details of the logged in user from Oauth server
            User loginUser = await _projectUserCallRepository.GetUserByUserName(userName, accessToken);
            //Getting details of the specific project from Oauth server
            ProjectAc project = await _projectUserCallRepository.GetProjectDetails(projectId, accessToken);
            //Getting scrum for a specific project
            Scrum scrum = _scrumDataRepository.FirstOrDefault(x => x.ProjectId == project.Id);
            ScrumProjectDetails scrumProjectDetail = new ScrumProjectDetails();
            scrumProjectDetail.ScrumDate = scrumDate.ToString(_stringConstant.FormatForDate);
            scrumProjectDetail.ProjectCreationDate = project.CreatedDate;
            //getting scrum answers of employees in a specific project
            scrumProjectDetail.EmployeeScrumAnswers = GetEmployeeScrumDetails(project,scrum,loginUser, scrumDate);
            return scrumProjectDetail;
        }

        #endregion
    }
}


