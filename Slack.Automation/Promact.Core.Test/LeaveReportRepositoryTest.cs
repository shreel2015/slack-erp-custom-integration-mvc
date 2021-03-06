﻿using Autofac;
using Moq;
using Promact.Core.Repository.HttpClientRepository;
using Promact.Core.Repository.LeaveReportRepository;
using Promact.Core.Repository.LeaveRequestRepository;
using Promact.Erp.DomainModel.ApplicationClass;
using Promact.Erp.DomainModel.Models;
using Promact.Erp.Util.StringConstants;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Promact.Core.Test
{
    public class LeaveReportRepositoryTest
    {
        private IComponentContext _componentContext;
        private ILeaveReportRepository _leaveReportRepository;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly Mock<IHttpClientRepository> _mockHttpClient;
        private readonly IStringConstantRepository _stringConstant;
        private LeaveRequest leave = new LeaveRequest();
        public LeaveReportRepositoryTest()
        {
            _componentContext = AutofacConfig.RegisterDependancies();
            _leaveReportRepository = _componentContext.Resolve<ILeaveReportRepository>();
            _leaveRequestRepository = _componentContext.Resolve<ILeaveRequestRepository>();
            _mockHttpClient = _componentContext.Resolve<Mock<IHttpClientRepository>>();
            _stringConstant = _componentContext.Resolve<IStringConstantRepository>();
            Initialize();
        }

        /// <summary>
        /// Method to test LeaveReport when the logged in person is admin
        /// </summary>
        [Fact, Trait("Category", "Required")]
        public void LeaveReportAdminTest()
        {
            var response = Task.FromResult(_stringConstant.UserDetailsFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.LoginUserDetail, _stringConstant.TestUserName);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            var requestIdUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.EmployeeIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestIdUrl, _stringConstant.TestAccessToken)).Returns(response);
            leave.EmployeeId = _stringConstant.EmployeeIdForTest;
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReports = _leaveReportRepository.LeaveReport(_stringConstant.TestAccessToken, _stringConstant.TestUserName).Result;
            Assert.Equal(1, leaveReports.Count());
        }

        /// <summary>
        /// Method to test LeaveReport when the logged in person is employee
        /// </summary>
        [Fact, Trait("Category", "Required")]
        public void LeaveReportEmployeeTest()
        {
            var response = Task.FromResult(_stringConstant.EmployeeDetailFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.LoginUserDetail, _stringConstant.TestUserName);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            var requestIdUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.StringIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestIdUrl, _stringConstant.TestAccessToken)).Returns(response);
            leave.EmployeeId = _stringConstant.StringIdForTest;
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReports = _leaveReportRepository.LeaveReport(_stringConstant.TestAccessToken, _stringConstant.TestUserName).Result;
            Assert.Equal(1, leaveReports.Count());
        }

        /// <summary>
        /// Method to test LeaveReport when the logged in person is teamleader
        /// </summary>
        [Fact, Trait("Category", "Required")]
        public void LeaveReportTeamLeaderTest()
        {
            var response = Task.FromResult(_stringConstant.TeamLeaderDetailFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.LoginUserDetail, _stringConstant.TestUserName);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            var requestIdUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.StringIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestIdUrl, _stringConstant.TestAccessToken)).Returns(response);
            var responseProject = Task.FromResult(_stringConstant.ProjectUsers);
            var requestProjectUrl = string.Format("{0}{1}", _stringConstant.ProjectUsersByTeamLeaderId, _stringConstant.StringIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.ProjectUrl, requestProjectUrl, _stringConstant.TestAccessToken)).Returns(responseProject);
            leave.EmployeeId = _stringConstant.StringIdForTest;
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReports = _leaveReportRepository.LeaveReport(_stringConstant.TestAccessToken, _stringConstant.TestUserName).Result;
            Assert.Equal(1, leaveReports.Count());
        }

        /// <summary>
        /// Method to test LeaveReportDetails that returns the details of leave for an employee
        /// </summary>
        [Fact, Trait("Category", "Required")]
        public void LeaveReportDetailTest()
        {
            var response = Task.FromResult(_stringConstant.UserDetailsFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.EmployeeIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReport = _leaveReportRepository.LeaveReportDetails(_stringConstant.EmployeeIdForTest, _stringConstant.TestAccessToken).Result;
            Assert.NotNull(leaveReport);
        }

        /// <summary>
        /// Method to test LeaveReport that returns the list of employees with their leave status for incorrect values
        /// </summary> 
        [Fact, Trait("Category", "Required")]
        public void LeaveReportTestFalse()
        {
            var response = Task.FromResult(_stringConstant.UserDetailsFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.LoginUserDetail, _stringConstant.TestUserName);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            var requestIdUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.EmployeeIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestIdUrl, _stringConstant.TestAccessToken)).Returns(response);
            leave.EmployeeId = _stringConstant.EmployeeIdForTest;
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReports = _leaveReportRepository.LeaveReport(_stringConstant.TestAccessToken, _stringConstant.TestUserName).Result;
            Assert.NotEqual(2, leaveReports.Count());
        }



        /// <summary>
        /// Method to test LeaveReportDetails that returns the details of leave for an employee with incorrect values
        /// </summary>
        [Fact, Trait("Category", "Required")]
        public void LeaveReportDetailTestFalse()
        {
            var response = Task.FromResult(_stringConstant.UserDetailsFromOauthServer);
            var requestUrl = string.Format("{0}{1}", _stringConstant.UserDetailUrl, _stringConstant.EmployeeIdForTest);
            _mockHttpClient.Setup(x => x.GetAsync(_stringConstant.UserUrl, requestUrl, _stringConstant.TestAccessToken)).Returns(response);
            _leaveRequestRepository.ApplyLeave(leave);
            var leaveReport = _leaveReportRepository.LeaveReportDetails(_stringConstant.EmployeeIdForTest, _stringConstant.TestAccessToken).Result;
            Assert.NotEqual(2, leaveReport.Count());
        }


        /// <summary>
        /// A method is used to initialize variables which are repetitively used
        /// </summary>
        public void Initialize()
        {
            leave.FromDate = DateTime.UtcNow;
            leave.EndDate = DateTime.UtcNow;
            leave.Reason = _stringConstant.LeaveReasonForTest;
            leave.RejoinDate = DateTime.UtcNow;
            leave.Status = Condition.Approved;
            leave.Type = LeaveType.cl;
            leave.CreatedOn = DateTime.UtcNow;
        }
    }
}
