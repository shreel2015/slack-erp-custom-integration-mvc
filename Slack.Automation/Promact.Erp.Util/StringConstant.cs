﻿using System;

namespace Promact.Erp.Util
{
    public class StringConstant
    {
        public static string EmailSubject = "Leave Application";
        public static string FromDate = "FromDate";
        public static string EndDate = "EndDate";
        public static string Reason = "Reason";
        public static string Type = "Type";
        public static string Status = "Status";
        public static string ReJoinDate = "ReJoinDate";
        public static string CreatedOn = "CreatedOn";
        public static string WebRequestContentType = "application/json; charset=UTF-8";
        public static string DateFormat = "dd,MM,yyyy";
        public static string ResponseTypeEphemeral = "ephemeral";
        public static string Approved = "Approved";
        public static string Button = "button";
        public static string Rejected = "Rejected";
        public static string Fallback = "Leave Applied";
        public static string Color = "#3AA3E3";
        public static string AttachmentType = "default";
        public static string CancelLeaveError = "You are trying with wrong leaveId which not belong to you";
        public static string SlackHelpMessage = string.Format("For leave apply: /leaves apply [Reason] [FromDate] [EndDate] [LeaveType] [RejoinDate]{0}For leave list of Yours : /leaves list{0}For leave list of others : /leaves list [@user]{0}For leave Cancel : /leaves cancel [leave Id number]{0}For leave status of Yours : /leaves status{0}For leave status of others : /leaves status [@user]{0}For leaves balance: /leaves balance", Environment.NewLine);
        public static string SlackErrorMessage = "Sorry, I didn't quite get that. I'm easily confused. Perhaps try the words in a different order. For help : /leaves help";


        public static string ProjectDetailsUrl = "fetchProject/";
        public static string UsersDetailByGroupUrl = "fetchProjectUsers/";
        public static string UserDetailsByIdUrl = "fetchUserById/";
        public static string UserDetailByUserNameUrl = "fetchbyusername/";
        public static string UrlRtmStart = "https://slack.com/api/rtm.start";
        public static string OAuthAuthorizationScopeAndClientId = "?scope=incoming-webhook,commands,bot,users:read&client_id=";
        public static string UserDetailsUrl = "userDetails/";
        public static string TeamLeaderDetailsUrl = "teamLeaderDetails/";
        public static string ManagementDetailsUrl = "managementDetails";
        public static string OAuthAcessUrl = "https://slack.com/api/oauth.access";
        public static string ProjectDetailsByUserNameUrl = "projectByUserName/";
        public static string ProjectUserDetailsUrl = "project/userDetails/";
        public static string ProjectTeamLeaderDetailsUrl = "project/teamLeadersDetails/";
        public static string ProjectManagementDetailsUrl = "project/Admin";
        public static string UserDetailUrl = "userDetail/";
        public static string ThankYou = "Thank You";
        public static string InternalError = "Internal Error";
        public static string SlackUserListUrl = "https://slack.com/api/users.list";
        public static string TaskMailBotStatusErrorMessage = "Status should be completed/inprogress/roadblock";
        public static string TaskMailBotHourErrorMessage = "Please enter numeric value. And it should be in range of 0.5 to 8";
        public static string TaskMailDescription = "Descriptions";
        public static string TaskMailHours = "Hours";
        public static string TaskMailComment = "Comment";
        public static string TaskMailStatus = "Status";
        public static string SendTaskMailConfirmationErrorMessage = "Please enter yes or no";
        public static string RequestToStartTaskMail = "Please start task mail";
        public static string AlreadyMailSend = "You have already sended mail for today. No more task mail for today";
        public static string TaskMailSubject = "Task Mail";
        public static string FirstNameForTest = "siddhartha";
        public static string AccessTokenForTest = "94d56876-fb02-45a9-8b01-c56046482d17";
        public static string EmailForTest = "siddhartha@promactinfo.com";
        public static string StringIdForTest = "13b0f2ca-92f5-4713-a67e-37e50172e148";
        public static string LastNameForTest = "shaw";
        public static string UserDetailsFromOauthServer = "{\"firstName\":\"roshni\",\"lastName\":\"Promact\",\"isActive\":false,\"numberOfCasualLeave\":0.0,\"numberOfSickLeave\":0.0,\"joiningDate\":\"0001-01-01T00:00:00\",\"slackUserName\":null,\"projects\":null,\"createdBy\":null,\"createdDateTime\":\"0001-01-01T00:00:00\",\"updatedBy\":null,\"updatedDateTime\":\"0001-01-01T00:00:00\",\"id\":\"13b0f2ca-92f5-4713-a67e-37e50172e148\",\"userName\":null,\"normalizedUserName\":null,\"email\":\"roshni@promactinfo.com\",\"normalizedEmail\":null,\"emailConfirmed\":false,\"passwordHash\":null,\"securityStamp\":null,\"concurrencyStamp\":\"a39b2cff-51e2-4f1d-bde9-096cefb17497\",\"phoneNumber\":null,\"phoneNumberConfirmed\":false,\"twoFactorEnabled\":false,\"lockoutEnd\":null,\"lockoutEnabled\":false,\"accessFailedCount\":0,\"roles\":[],\"claims\":[],\"logins\":[]}";
        public static string SlashCommandText = "Apply Hello 30-09-2016 30-09-2016 Casual 30-09-2016";
        public static string PromactStringName = "Promact";
        public static string QuestionForTest = "On which task you worked on Today?";
        public static string TeamLeaderDetailsFromOauthServer = "[{\"firstName\":null,\"lastName\":null,\"isActive\":false,\"numberOfCasualLeave\":0.0,\"numberOfSickLeave\":0.0,\"joiningDate\":\"0001-01-01T00:00:00\",\"slackUserName\":null,\"projects\":null,\"createdBy\":null,\"createdDateTime\":\"0001-01-01T00:00:00\",\"updatedBy\":null,\"updatedDateTime\":\"0001-01-01T00:00:00\",\"id\":\"24954a25-7af6-488e-9c5f-970958c62eeb\",\"userName\":\"gourav@promactinfo.com\",\"normalizedUserName\":null,\"email\":\"gourav@promactinfo.com\",\"normalizedEmail\":null,\"emailConfirmed\":false,\"passwordHash\":null,\"securityStamp\":null,\"concurrencyStamp\":\"00836465-b3d0-48ee-acb4-f0bff1c1834b\",\"phoneNumber\":null,\"phoneNumberConfirmed\":false,\"twoFactorEnabled\":false,\"lockoutEnd\":null,\"lockoutEnabled\":false,\"accessFailedCount\":0,\"roles\":[],\"claims\":[],\"logins\":[]}]";
        public static string CommentAndDescriptionForTest = "Doing Test Task";
        public static string ManagementDetailsFromOauthServer = "[{\"firstName\":\"roshni\",\"lastName\":null,\"isActive\":false,\"numberOfCasualLeave\":0.0,\"numberOfSickLeave\":0.0,\"joiningDate\":\"0001-01-01T00:00:00\",\"slackUserName\":null,\"projects\":null,\"createdBy\":null,\"createdDateTime\":\"0001-01-01T00:00:00\",\"updatedBy\":null,\"updatedDateTime\":\"0001-01-01T00:00:00\",\"id\":\"5e6d8293-98ad-4249-b4ff-d4baa5da09bb\",\"userName\":null,\"normalizedUserName\":null,\"email\":\"roshni@promactinfo.com\",\"normalizedEmail\":null,\"emailConfirmed\":false,\"passwordHash\":null,\"securityStamp\":null,\"concurrencyStamp\":\"22914d35-4125-4c89-b67f-bb2060ed4247\",\"phoneNumber\":null,\"phoneNumberConfirmed\":false,\"twoFactorEnabled\":false,\"lockoutEnd\":null,\"lockoutEnabled\":false,\"accessFailedCount\":0,\"roles\":[],\"claims\":[],\"logins\":[]}]";
        public static string TeamLeaderEmailForTest = "gourav@promactinfo.com";
        public static string ManagementFirstForTest = "roshni";
        public static string ManagementEmailForTest = "roshni@promactinfo.com";
        public static string LeaveReasonForTest = "Testing";
        public static string LeaveTypeForTest = "Casual";
        public static string ChannelId = "channel_id";
        public static string ChannelName = "channel_name";
        public static string Command = "command";
        public static string ResponseUrl = "response_url";
        public static string TeamDomain = "team_domain";
        public static string TeamId = "team_id";
        public static string Text = "text";
        public static string Token = "token";
        public static string UserId = "user_id";
        public static string UserName = "user_name";
        public static string LeaveBot = "LeaveBot";
        public static string UnderConstruction = "Still under Construction";
        public static string Hello = "Hello All";
        public static string All = "All";
        public static string StringHourForTest = "4";
        public static string AfterLogIn = "AfterLogIn";
        public static string Home = "Home";
        public static string Index = "Index";
        public static string WebConfig = "~/web.config";
        public static string MailSetting = "system.net/mailSettings";
    }
}
