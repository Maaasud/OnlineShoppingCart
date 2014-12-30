using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OnlineShoppingCart.BAL.Repository;
using OnlineShoppingCart.DAL;

namespace OnlineShoppingCart.Model
{
    public class UserModel : User
    {
        private OnlineShoppingCartDbContext _dbContext;

        public UserModel(OnlineShoppingCartDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public bool Save(out int userID)
        {
            userID = 0;
            try
            {
                //DAL.Users
                Users user = new Users();
                user.FirstName = this.FirstName;
                user.LastName = this.LastName;
                
                //user.Email = this.Email;
                //user.Password = CommonClass.Encrypt(this.Password);
                //DateTime birthDateTime = new DateTime(this.BirthYear, this.BirthMonth, this.BirthDay);
                //user.Birthday = birthDateTime;
                //user.Gender = this.Gender;
                //user.IsVerified = false;
                //this._entities.tblUser.Add(user);
                //this._entities.SaveChanges();

                userID = user.UserID;
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool Verify(int userID, bool isVerified)
        {
            try
            {
                //User user = GetUser(userID);
                //user.IsVerified = isVerified;
                //this._entities.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        //public IQueryable<tblUser> GetUser()
        //{
        //    var query = from q in this._entities.tblUser select q;
        //    return query;
        //}

        //public User GetUser(int userID)
        //{
        //    return GetUser(userID, null);
        //}

        //public User GetUser(string emailId)
        //{
        //    return GetUser(0, emailId);
        //}

        //public User GetUser(int userID, string emailId)
        //{
        //    var query = GetUser();
        //    if (userID != 0)
        //    {
        //        query = query.Where(q => q.UserID == userID);
        //    }

        //    if (!string.IsNullOrEmpty(emailId))
        //    {
        //        query = query.Where(q => q.Email == emailId);
        //    }

        //    tblUser user = query.SingleOrDefault();
        //    this.FirstName = user.FirstName;
        //    this.LastName = user.LastName;
        //    this.Email = user.Email;
        //    this.Gender = user.Gender;
        //    this.IsVerified = user.IsVerified;
        //    return this;
        //}
    }
}