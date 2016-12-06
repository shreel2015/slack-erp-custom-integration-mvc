﻿
namespace Promact.Erp.DomainModel.ApplicationClass
{
   public class LeaveReport
    {
        /// <summary>
        /// Id of the employee
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Name of the employee
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// User Name of the employee
        /// </summary>
        public string EmployeeUserName { get; set; }

        /// <summary>
        /// Total number of sick leaves alloted
        /// </summary>
        public double? TotalSickLeave { get; set; }

        /// <summary>
        /// Total number of casual leaves alloted
        /// </summary>
        public double? TotalCasualLeave { get; set; }

        /// <summary>
        /// Number of casusal leaves used
        /// </summary>
        public double? UtilisedCasualLeave { get; set; }

        /// <summary>
        /// Number of casual leaves left
        /// </summary>
        public double? BalanceCasualLeave { get; set; }


        /// <summary>
        /// Number of sick leaves used
        /// </summary>
        public double UtilisedSickLeave { get; set; }

        /// <summary>
        /// Number of sick leaves left
        /// </summary>
        public double BalanceSickLeave { get; set; }

        /// <summary>
        /// Role of the user
        /// </summary>
        public string Role { get; set; }

    }
}
