﻿/**
 *
 * @package     Parking.API.Models
 * @author      The JSONs
 * @copyright   2012 - 20XX
 * @license     Propietary
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieena.Parking.API.Models
{
    using Interfaces;

    /// <summary>
    /// Roles in the system. 
    /// </summary>
    public partial class Role : IRole
    {
        
        /// <summary>
        /// Gets all the roles in the app
        /// </summary>
        /// <returns></returns>
        public static List<Role> GetAll()
        {
            using (EntityContext ctx = new EntityContext())
            {
                return ctx.Roles.ToList();
            }
        }

        public static List<Role> GetRolesForUser(int userId)
        {
            using (EntityContext ctx = new EntityContext())
            {
                List<int> userRoles = ctx.UserRoles.Where(ur => ur.UserId.Equals(userId)).Select(ur => ur.RoleId).ToList();
                return ctx.Roles.Where(r => userRoles.Contains(r.RoleId)).ToList();
            }
        }

        public static List<Role> GetRolesForUser(string email)
        {
            using (EntityContext ctx = new EntityContext())
            {
                User u = User.GetByEmail(email);
                List<int> userRoles = ctx.UserRoles.Where(ur => ur.UserId.Equals(u.UserId)).Select(ur => ur.RoleId).ToList();
                return ctx.Roles.Where(r => userRoles.Contains(r.RoleId)).ToList();
            }
        }

        public static List<User> GetUsersInRole(string roleName)
        {
            using (EntityContext ctx = new EntityContext())
            {
                int roleId = ctx.Roles.Where(r => r.RoleName.Equals(roleName)).First().RoleId;

                List<int> userRoles = ctx.UserRoles.Where(ur => ur.RoleId.Equals(roleId)).Select(ur => ur.UserId).ToList();
                return ctx.Users.Where(u => userRoles.Contains(u.UserId)).ToList();
            } 
        }
    }
}
