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
    public class UserModel : UserRepository
    {
        private OnlineShoppingCartDbContext _dbContext;

        public UserModel() { }

        public UserModel(OnlineShoppingCartDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Save(UserModel userModel,out int userID)
        {
            userID = 0;
            bool isSuccess = false;
            //this._dbContext.Database.;
            //System.Data.Common.DbTransaction transaction = this.context.Connection.BeginTransaction();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    DAL.Contact contact = new DAL.Contact();
                    contact.Email = userModel.Contact.Email;
                    contact.Phone = userModel.Contact.Phone;
                    contact.DateCreated = DateTime.Now;
                    this._dbContext.Contact.Add(contact);
                    this._dbContext.SaveChanges();

                    Users user = new Users();
                    user.FirstName = userModel.FirstName;
                    user.LastName = userModel.LastName;
                    user.Password = userModel.Password;
                    user.ContactID = contact.ContactID;
                    user.DateCreated = DateTime.Now;
                    this._dbContext.Users.Add(user);
                    this._dbContext.SaveChanges();

                    userID = user.UserID;
                    //Insert log that user is created

                    transaction.Commit();
                    transaction.Dispose();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    isSuccess = false;
                    throw ex;
                }
            }

            return isSuccess;
            //user.Email = this.Email;
            //user.Password = CommonClass.Encrypt(this.Password);
            //DateTime birthDateTime = new DateTime(this.BirthYear, this.BirthMonth, this.BirthDay);
            //user.Birthday = birthDateTime;
            //user.Gender = this.Gender;
            //user.IsVerified = false;
            //this._entities.tblUser.Add(user);
            //this._entities.SaveChanges();
            
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