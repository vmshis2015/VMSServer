using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
    /// <summary>
    /// Controller class for Sys_GroupRoles
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SysGroupRoleController
    {
        // Preload our schema..
        SysGroupRole thisSchemaLoad = new SysGroupRole();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public SysGroupRoleCollection FetchAll()
        {
            SysGroupRoleCollection coll = new SysGroupRoleCollection();
            Query qry = new Query(SysGroupRole.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysGroupRoleCollection FetchByID(object BranchID)
        {
            SysGroupRoleCollection coll = new SysGroupRoleCollection().Where("BranchID", BranchID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysGroupRoleCollection FetchByQuery(Query qry)
        {
            SysGroupRoleCollection coll = new SysGroupRoleCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object BranchID)
        {
            return (SysGroupRole.Delete(BranchID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object BranchID)
        {
            return (SysGroupRole.Destroy(BranchID) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string BranchID,int GroupID,int RoleID,int ParentRoleID)
        {
            Query qry = new Query(SysGroupRole.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("BranchID", BranchID).AND("GroupID", GroupID).AND("RoleID", RoleID).AND("ParentRoleID", ParentRoleID);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string BranchID,int GroupID,int RoleID,int ParentRoleID)
	    {
		    SysGroupRole item = new SysGroupRole();
		    
            item.BranchID = BranchID;
            
            item.GroupID = GroupID;
            
            item.RoleID = RoleID;
            
            item.ParentRoleID = ParentRoleID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string BranchID,int GroupID,int RoleID,int ParentRoleID)
	    {
		    SysGroupRole item = new SysGroupRole();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.BranchID = BranchID;
				
			item.GroupID = GroupID;
				
			item.RoleID = RoleID;
				
			item.ParentRoleID = ParentRoleID;
				
	        item.Save(UserName);
	    }
    }
}
