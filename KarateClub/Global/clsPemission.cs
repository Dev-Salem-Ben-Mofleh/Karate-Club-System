using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateClub.Global
{


    public class clsPemission
    {
        public enum enMainMenuePermissions
        {
            pAll = 0, pMamnageMembers = 1, pMamnageInstructors = 2, PManageUsers = 4,
            pManageMembersInstructors = 8, pManageBeltRanks = 16, pManageSubscriptionPeriod = 32, pManageBeltTest = 64
       , pManagePayment = 128
        };

        static public bool pALL
        { get; set; }
        static public bool pMamnageMembers
        { get; set; }
        static public bool pMamnageInstructors
        { get; set; }
        static public bool PManageUsers
        { get; set; }
        static public bool pManageMembersInstructors
        { get; set; }
        static public bool pManageBeltRanks
        { get; set; }
        static public bool pManageSubscriptionPeriod
        { get; set; }
        static public bool pManageBeltTest
        { get; set; }

        static public bool pManagePayment
        { get; set; }


        static public void CheckAccessPermission(byte Permission)
        {
            if (Permission == (byte)enMainMenuePermissions.pAll)
            {
                pALL = true;
                return;
            }
            else
                pALL = false;

          

            if (((byte)enMainMenuePermissions.pMamnageMembers & Permission) == (byte)enMainMenuePermissions.pMamnageMembers)
                pMamnageMembers= true;
            else
                pMamnageMembers = false;

            

            if (((byte)enMainMenuePermissions.pMamnageInstructors & Permission) == (byte)enMainMenuePermissions.pMamnageInstructors)
                pMamnageInstructors = true;
            else
                pMamnageInstructors = false;

            if (((byte)enMainMenuePermissions.PManageUsers & Permission) == (byte)enMainMenuePermissions.PManageUsers)
                PManageUsers = true;
            else
                PManageUsers = false;

            if (((byte)enMainMenuePermissions.pManageBeltRanks & Permission) == (byte)enMainMenuePermissions.pManageBeltRanks)
                pManageBeltRanks = true;
            else
                pManageBeltRanks = false;

            if (((byte)enMainMenuePermissions.pManageMembersInstructors & Permission) == (byte)enMainMenuePermissions.pManageMembersInstructors)
                pManageMembersInstructors = true;
            else
                pManageMembersInstructors = false;


            if (((byte)enMainMenuePermissions.pManageBeltTest & Permission) == (byte)enMainMenuePermissions.pManageBeltTest)
                pManageBeltTest = true;
            else
                pManageBeltTest = false;

            if (((byte)enMainMenuePermissions.pManageSubscriptionPeriod & Permission) == (byte)enMainMenuePermissions.pManageSubscriptionPeriod)
                pManageSubscriptionPeriod = true;
            else
                pManageSubscriptionPeriod = false;

            if (((byte)enMainMenuePermissions.pManagePayment & Permission) == (byte)enMainMenuePermissions.pManagePayment)
                pManagePayment = true;
            else
                pManagePayment = false;

        }

    }
}

