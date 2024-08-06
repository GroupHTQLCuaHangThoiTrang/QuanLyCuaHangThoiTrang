using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class UserBLL
    {
        public UserBLL() { }

        public bool CheckCorrect_Email(string _email)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                string email = (from e in ql.Users where e.email == _email select e.email).FirstOrDefault();
                if (email != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool CheckCorrect_Password(string _email, string _pass)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                string pass = (from e in ql.Users where (e.email == _email && e.password == _pass) select e.password).FirstOrDefault();
                if (pass != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool isAdmin(string _email)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                bool isAdmin = (bool)(from u in ql.Users where u.email == _email select u.is_admin).FirstOrDefault();
                if(isAdmin == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }    
        }

        public List<User> Load_User()
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                var list_user = from u in ql.Users select u;
                return list_user.ToList();
            } 
        }

        public bool Add_User(User _user)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                if (CheckCorrect_Email(_user.email))
                {
                    //Trùng email
                    return false;
                }
                else
                {
                    try
                    {
                        ql.Users.InsertOnSubmit(_user);
                        ql.SubmitChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }

        public bool Delete_User(int _p)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                try
                {
                    User user = ql.Users.Where(s => s.user_id == _p).Single();
                    ql.Users.DeleteOnSubmit(user);
                    ql.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool Update_User(User _user)
        {
            using (WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext())
            {
                try
                {
                
                    User user = ql.Users.Where(u => u.user_id == _user.user_id).Single();

                
                    user.user_first_name = _user.user_first_name;
                    user.user_last_name = _user.user_last_name;
                    user.email = _user.email;
                    user.password = _user.password;
                    user.is_admin = _user.is_admin;

                  
                    ql.SubmitChanges();

                    
                    return true;
                }
                catch (InvalidOperationException ex)
                {
                    /
                    Console.WriteLine("Lỗi: Không tìm thấy người dùng hoặc có nhiều hơn một người dùng có cùng user_id.");
                    Console.WriteLine(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi khác
                    Console.WriteLine("Đã xảy ra lỗi khi cập nhật thông tin người dùng.");
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
