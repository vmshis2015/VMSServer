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
	/// Strongly-typed collection for the KcbQm class.
	/// </summary>
    [Serializable]
	public partial class KcbQmCollection : ActiveList<KcbQm, KcbQmCollection>
	{	   
		public KcbQmCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>KcbQmCollection</returns>
		public KcbQmCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                KcbQm o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the kcb_qms table.
	/// </summary>
	[Serializable]
	public partial class KcbQm : ActiveRecord<KcbQm>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public KcbQm()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public KcbQm(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public KcbQm(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public KcbQm(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("kcb_qms", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarSoQms = new TableSchema.TableColumn(schema);
				colvarSoQms.ColumnName = "so_qms";
				colvarSoQms.DataType = DbType.Int32;
				colvarSoQms.MaxLength = 0;
				colvarSoQms.AutoIncrement = false;
				colvarSoQms.IsNullable = true;
				colvarSoQms.IsPrimaryKey = false;
				colvarSoQms.IsForeignKey = false;
				colvarSoQms.IsReadOnly = false;
				colvarSoQms.DefaultSetting = @"";
				colvarSoQms.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoQms);
				
				TableSchema.TableColumn colvarLoaiQms = new TableSchema.TableColumn(schema);
				colvarLoaiQms.ColumnName = "loai_qms";
				colvarLoaiQms.DataType = DbType.Byte;
				colvarLoaiQms.MaxLength = 0;
				colvarLoaiQms.AutoIncrement = false;
				colvarLoaiQms.IsNullable = true;
				colvarLoaiQms.IsPrimaryKey = false;
				colvarLoaiQms.IsForeignKey = false;
				colvarLoaiQms.IsReadOnly = false;
				
						colvarLoaiQms.DefaultSetting = @"((0))";
				colvarLoaiQms.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoaiQms);
				
				TableSchema.TableColumn colvarIdBenhnhan = new TableSchema.TableColumn(schema);
				colvarIdBenhnhan.ColumnName = "id_benhnhan";
				colvarIdBenhnhan.DataType = DbType.Int32;
				colvarIdBenhnhan.MaxLength = 0;
				colvarIdBenhnhan.AutoIncrement = false;
				colvarIdBenhnhan.IsNullable = true;
				colvarIdBenhnhan.IsPrimaryKey = false;
				colvarIdBenhnhan.IsForeignKey = false;
				colvarIdBenhnhan.IsReadOnly = false;
				colvarIdBenhnhan.DefaultSetting = @"";
				colvarIdBenhnhan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBenhnhan);
				
				TableSchema.TableColumn colvarMaLankham = new TableSchema.TableColumn(schema);
				colvarMaLankham.ColumnName = "ma_lankham";
				colvarMaLankham.DataType = DbType.String;
				colvarMaLankham.MaxLength = 50;
				colvarMaLankham.AutoIncrement = false;
				colvarMaLankham.IsNullable = true;
				colvarMaLankham.IsPrimaryKey = false;
				colvarMaLankham.IsForeignKey = false;
				colvarMaLankham.IsReadOnly = false;
				colvarMaLankham.DefaultSetting = @"";
				colvarMaLankham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaLankham);
				
				TableSchema.TableColumn colvarMaKhoakcb = new TableSchema.TableColumn(schema);
				colvarMaKhoakcb.ColumnName = "ma_khoakcb";
				colvarMaKhoakcb.DataType = DbType.String;
				colvarMaKhoakcb.MaxLength = 50;
				colvarMaKhoakcb.AutoIncrement = false;
				colvarMaKhoakcb.IsNullable = true;
				colvarMaKhoakcb.IsPrimaryKey = false;
				colvarMaKhoakcb.IsForeignKey = false;
				colvarMaKhoakcb.IsReadOnly = false;
				colvarMaKhoakcb.DefaultSetting = @"";
				colvarMaKhoakcb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaKhoakcb);
				
				TableSchema.TableColumn colvarMaQuay = new TableSchema.TableColumn(schema);
				colvarMaQuay.ColumnName = "ma_quay";
				colvarMaQuay.DataType = DbType.String;
				colvarMaQuay.MaxLength = 50;
				colvarMaQuay.AutoIncrement = false;
				colvarMaQuay.IsNullable = true;
				colvarMaQuay.IsPrimaryKey = false;
				colvarMaQuay.IsForeignKey = false;
				colvarMaQuay.IsReadOnly = false;
				colvarMaQuay.DefaultSetting = @"";
				colvarMaQuay.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaQuay);
				
				TableSchema.TableColumn colvarTrangThai = new TableSchema.TableColumn(schema);
				colvarTrangThai.ColumnName = "trang_thai";
				colvarTrangThai.DataType = DbType.Byte;
				colvarTrangThai.MaxLength = 0;
				colvarTrangThai.AutoIncrement = false;
				colvarTrangThai.IsNullable = true;
				colvarTrangThai.IsPrimaryKey = false;
				colvarTrangThai.IsForeignKey = false;
				colvarTrangThai.IsReadOnly = false;
				
						colvarTrangThai.DefaultSetting = @"((0))";
				colvarTrangThai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrangThai);
				
				TableSchema.TableColumn colvarNgayTao = new TableSchema.TableColumn(schema);
				colvarNgayTao.ColumnName = "ngay_tao";
				colvarNgayTao.DataType = DbType.DateTime;
				colvarNgayTao.MaxLength = 0;
				colvarNgayTao.AutoIncrement = false;
				colvarNgayTao.IsNullable = true;
				colvarNgayTao.IsPrimaryKey = false;
				colvarNgayTao.IsForeignKey = false;
				colvarNgayTao.IsReadOnly = false;
				colvarNgayTao.DefaultSetting = @"";
				colvarNgayTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTao);
				
				TableSchema.TableColumn colvarTrangthaiIn = new TableSchema.TableColumn(schema);
				colvarTrangthaiIn.ColumnName = "trangthai_in";
				colvarTrangthaiIn.DataType = DbType.Boolean;
				colvarTrangthaiIn.MaxLength = 0;
				colvarTrangthaiIn.AutoIncrement = false;
				colvarTrangthaiIn.IsNullable = true;
				colvarTrangthaiIn.IsPrimaryKey = false;
				colvarTrangthaiIn.IsForeignKey = false;
				colvarTrangthaiIn.IsReadOnly = false;
				colvarTrangthaiIn.DefaultSetting = @"";
				colvarTrangthaiIn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrangthaiIn);
				
				TableSchema.TableColumn colvarMaDoituongKcb = new TableSchema.TableColumn(schema);
				colvarMaDoituongKcb.ColumnName = "ma_doituongKcb";
				colvarMaDoituongKcb.DataType = DbType.String;
				colvarMaDoituongKcb.MaxLength = 30;
				colvarMaDoituongKcb.AutoIncrement = false;
				colvarMaDoituongKcb.IsNullable = true;
				colvarMaDoituongKcb.IsPrimaryKey = false;
				colvarMaDoituongKcb.IsForeignKey = false;
				colvarMaDoituongKcb.IsReadOnly = false;
				colvarMaDoituongKcb.DefaultSetting = @"";
				colvarMaDoituongKcb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaDoituongKcb);
				
				TableSchema.TableColumn colvarIdKhoakcb = new TableSchema.TableColumn(schema);
				colvarIdKhoakcb.ColumnName = "id_khoakcb";
				colvarIdKhoakcb.DataType = DbType.Int32;
				colvarIdKhoakcb.MaxLength = 0;
				colvarIdKhoakcb.AutoIncrement = false;
				colvarIdKhoakcb.IsNullable = true;
				colvarIdKhoakcb.IsPrimaryKey = false;
				colvarIdKhoakcb.IsForeignKey = false;
				colvarIdKhoakcb.IsReadOnly = false;
				colvarIdKhoakcb.DefaultSetting = @"";
				colvarIdKhoakcb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKhoakcb);
				
				TableSchema.TableColumn colvarIdPhongkham = new TableSchema.TableColumn(schema);
				colvarIdPhongkham.ColumnName = "id_phongkham";
				colvarIdPhongkham.DataType = DbType.Int32;
				colvarIdPhongkham.MaxLength = 0;
				colvarIdPhongkham.AutoIncrement = false;
				colvarIdPhongkham.IsNullable = true;
				colvarIdPhongkham.IsPrimaryKey = false;
				colvarIdPhongkham.IsForeignKey = false;
				colvarIdPhongkham.IsReadOnly = false;
				colvarIdPhongkham.DefaultSetting = @"";
				colvarIdPhongkham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhongkham);
				
				TableSchema.TableColumn colvarIdKieukham = new TableSchema.TableColumn(schema);
				colvarIdKieukham.ColumnName = "id_kieukham";
				colvarIdKieukham.DataType = DbType.Int32;
				colvarIdKieukham.MaxLength = 0;
				colvarIdKieukham.AutoIncrement = false;
				colvarIdKieukham.IsNullable = true;
				colvarIdKieukham.IsPrimaryKey = false;
				colvarIdKieukham.IsForeignKey = false;
				colvarIdKieukham.IsReadOnly = false;
				colvarIdKieukham.DefaultSetting = @"";
				colvarIdKieukham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKieukham);
				
				TableSchema.TableColumn colvarSttKham = new TableSchema.TableColumn(schema);
				colvarSttKham.ColumnName = "stt_kham";
				colvarSttKham.DataType = DbType.Int32;
				colvarSttKham.MaxLength = 0;
				colvarSttKham.AutoIncrement = false;
				colvarSttKham.IsNullable = true;
				colvarSttKham.IsPrimaryKey = false;
				colvarSttKham.IsForeignKey = false;
				colvarSttKham.IsReadOnly = false;
				colvarSttKham.DefaultSetting = @"";
				colvarSttKham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSttKham);
				
				TableSchema.TableColumn colvarIdDichvukcb = new TableSchema.TableColumn(schema);
				colvarIdDichvukcb.ColumnName = "id_dichvukcb";
				colvarIdDichvukcb.DataType = DbType.Int32;
				colvarIdDichvukcb.MaxLength = 0;
				colvarIdDichvukcb.AutoIncrement = false;
				colvarIdDichvukcb.IsNullable = true;
				colvarIdDichvukcb.IsPrimaryKey = false;
				colvarIdDichvukcb.IsForeignKey = false;
				colvarIdDichvukcb.IsReadOnly = false;
				colvarIdDichvukcb.DefaultSetting = @"";
				colvarIdDichvukcb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDichvukcb);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("kcb_qms",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("SoQms")]
		[Bindable(true)]
		public int? SoQms 
		{
			get { return GetColumnValue<int?>(Columns.SoQms); }
			set { SetColumnValue(Columns.SoQms, value); }
		}
		  
		[XmlAttribute("LoaiQms")]
		[Bindable(true)]
		public byte? LoaiQms 
		{
			get { return GetColumnValue<byte?>(Columns.LoaiQms); }
			set { SetColumnValue(Columns.LoaiQms, value); }
		}
		  
		[XmlAttribute("IdBenhnhan")]
		[Bindable(true)]
		public int? IdBenhnhan 
		{
			get { return GetColumnValue<int?>(Columns.IdBenhnhan); }
			set { SetColumnValue(Columns.IdBenhnhan, value); }
		}
		  
		[XmlAttribute("MaLankham")]
		[Bindable(true)]
		public string MaLankham 
		{
			get { return GetColumnValue<string>(Columns.MaLankham); }
			set { SetColumnValue(Columns.MaLankham, value); }
		}
		  
		[XmlAttribute("MaKhoakcb")]
		[Bindable(true)]
		public string MaKhoakcb 
		{
			get { return GetColumnValue<string>(Columns.MaKhoakcb); }
			set { SetColumnValue(Columns.MaKhoakcb, value); }
		}
		  
		[XmlAttribute("MaQuay")]
		[Bindable(true)]
		public string MaQuay 
		{
			get { return GetColumnValue<string>(Columns.MaQuay); }
			set { SetColumnValue(Columns.MaQuay, value); }
		}
		  
		[XmlAttribute("TrangThai")]
		[Bindable(true)]
		public byte? TrangThai 
		{
			get { return GetColumnValue<byte?>(Columns.TrangThai); }
			set { SetColumnValue(Columns.TrangThai, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime? NgayTao 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("TrangthaiIn")]
		[Bindable(true)]
		public bool? TrangthaiIn 
		{
			get { return GetColumnValue<bool?>(Columns.TrangthaiIn); }
			set { SetColumnValue(Columns.TrangthaiIn, value); }
		}
		  
		[XmlAttribute("MaDoituongKcb")]
		[Bindable(true)]
		public string MaDoituongKcb 
		{
			get { return GetColumnValue<string>(Columns.MaDoituongKcb); }
			set { SetColumnValue(Columns.MaDoituongKcb, value); }
		}
		  
		[XmlAttribute("IdKhoakcb")]
		[Bindable(true)]
		public int? IdKhoakcb 
		{
			get { return GetColumnValue<int?>(Columns.IdKhoakcb); }
			set { SetColumnValue(Columns.IdKhoakcb, value); }
		}
		  
		[XmlAttribute("IdPhongkham")]
		[Bindable(true)]
		public int? IdPhongkham 
		{
			get { return GetColumnValue<int?>(Columns.IdPhongkham); }
			set { SetColumnValue(Columns.IdPhongkham, value); }
		}
		  
		[XmlAttribute("IdKieukham")]
		[Bindable(true)]
		public int? IdKieukham 
		{
			get { return GetColumnValue<int?>(Columns.IdKieukham); }
			set { SetColumnValue(Columns.IdKieukham, value); }
		}
		  
		[XmlAttribute("SttKham")]
		[Bindable(true)]
		public int? SttKham 
		{
			get { return GetColumnValue<int?>(Columns.SttKham); }
			set { SetColumnValue(Columns.SttKham, value); }
		}
		  
		[XmlAttribute("IdDichvukcb")]
		[Bindable(true)]
		public int? IdDichvukcb 
		{
			get { return GetColumnValue<int?>(Columns.IdDichvukcb); }
			set { SetColumnValue(Columns.IdDichvukcb, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varSoQms,byte? varLoaiQms,int? varIdBenhnhan,string varMaLankham,string varMaKhoakcb,string varMaQuay,byte? varTrangThai,DateTime? varNgayTao,bool? varTrangthaiIn,string varMaDoituongKcb,int? varIdKhoakcb,int? varIdPhongkham,int? varIdKieukham,int? varSttKham,int? varIdDichvukcb)
		{
			KcbQm item = new KcbQm();
			
			item.SoQms = varSoQms;
			
			item.LoaiQms = varLoaiQms;
			
			item.IdBenhnhan = varIdBenhnhan;
			
			item.MaLankham = varMaLankham;
			
			item.MaKhoakcb = varMaKhoakcb;
			
			item.MaQuay = varMaQuay;
			
			item.TrangThai = varTrangThai;
			
			item.NgayTao = varNgayTao;
			
			item.TrangthaiIn = varTrangthaiIn;
			
			item.MaDoituongKcb = varMaDoituongKcb;
			
			item.IdKhoakcb = varIdKhoakcb;
			
			item.IdPhongkham = varIdPhongkham;
			
			item.IdKieukham = varIdKieukham;
			
			item.SttKham = varSttKham;
			
			item.IdDichvukcb = varIdDichvukcb;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varSoQms,byte? varLoaiQms,int? varIdBenhnhan,string varMaLankham,string varMaKhoakcb,string varMaQuay,byte? varTrangThai,DateTime? varNgayTao,bool? varTrangthaiIn,string varMaDoituongKcb,int? varIdKhoakcb,int? varIdPhongkham,int? varIdKieukham,int? varSttKham,int? varIdDichvukcb)
		{
			KcbQm item = new KcbQm();
			
				item.Id = varId;
			
				item.SoQms = varSoQms;
			
				item.LoaiQms = varLoaiQms;
			
				item.IdBenhnhan = varIdBenhnhan;
			
				item.MaLankham = varMaLankham;
			
				item.MaKhoakcb = varMaKhoakcb;
			
				item.MaQuay = varMaQuay;
			
				item.TrangThai = varTrangThai;
			
				item.NgayTao = varNgayTao;
			
				item.TrangthaiIn = varTrangthaiIn;
			
				item.MaDoituongKcb = varMaDoituongKcb;
			
				item.IdKhoakcb = varIdKhoakcb;
			
				item.IdPhongkham = varIdPhongkham;
			
				item.IdKieukham = varIdKieukham;
			
				item.SttKham = varSttKham;
			
				item.IdDichvukcb = varIdDichvukcb;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SoQmsColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn LoaiQmsColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBenhnhanColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MaLankhamColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MaKhoakcbColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MaQuayColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangThaiColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangthaiInColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn MaDoituongKcbColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKhoakcbColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPhongkhamColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKieukhamColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn SttKhamColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDichvukcbColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string SoQms = @"so_qms";
			 public static string LoaiQms = @"loai_qms";
			 public static string IdBenhnhan = @"id_benhnhan";
			 public static string MaLankham = @"ma_lankham";
			 public static string MaKhoakcb = @"ma_khoakcb";
			 public static string MaQuay = @"ma_quay";
			 public static string TrangThai = @"trang_thai";
			 public static string NgayTao = @"ngay_tao";
			 public static string TrangthaiIn = @"trangthai_in";
			 public static string MaDoituongKcb = @"ma_doituongKcb";
			 public static string IdKhoakcb = @"id_khoakcb";
			 public static string IdPhongkham = @"id_phongkham";
			 public static string IdKieukham = @"id_kieukham";
			 public static string SttKham = @"stt_kham";
			 public static string IdDichvukcb = @"id_dichvukcb";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
