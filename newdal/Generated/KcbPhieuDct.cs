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
	/// Strongly-typed collection for the KcbPhieuDct class.
	/// </summary>
    [Serializable]
	public partial class KcbPhieuDctCollection : ActiveList<KcbPhieuDct, KcbPhieuDctCollection>
	{	   
		public KcbPhieuDctCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>KcbPhieuDctCollection</returns>
		public KcbPhieuDctCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                KcbPhieuDct o = this[i];
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
	/// This is an ActiveRecord class which wraps the kcb_phieu_dct table.
	/// </summary>
	[Serializable]
	public partial class KcbPhieuDct : ActiveRecord<KcbPhieuDct>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public KcbPhieuDct()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public KcbPhieuDct(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public KcbPhieuDct(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public KcbPhieuDct(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("kcb_phieu_dct", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPhieuDct = new TableSchema.TableColumn(schema);
				colvarIdPhieuDct.ColumnName = "id_phieu_dct";
				colvarIdPhieuDct.DataType = DbType.Int32;
				colvarIdPhieuDct.MaxLength = 0;
				colvarIdPhieuDct.AutoIncrement = true;
				colvarIdPhieuDct.IsNullable = false;
				colvarIdPhieuDct.IsPrimaryKey = true;
				colvarIdPhieuDct.IsForeignKey = false;
				colvarIdPhieuDct.IsReadOnly = false;
				colvarIdPhieuDct.DefaultSetting = @"";
				colvarIdPhieuDct.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhieuDct);
				
				TableSchema.TableColumn colvarMaPhieuDct = new TableSchema.TableColumn(schema);
				colvarMaPhieuDct.ColumnName = "ma_phieu_dct";
				colvarMaPhieuDct.DataType = DbType.String;
				colvarMaPhieuDct.MaxLength = 20;
				colvarMaPhieuDct.AutoIncrement = false;
				colvarMaPhieuDct.IsNullable = false;
				colvarMaPhieuDct.IsPrimaryKey = false;
				colvarMaPhieuDct.IsForeignKey = false;
				colvarMaPhieuDct.IsReadOnly = false;
				colvarMaPhieuDct.DefaultSetting = @"";
				colvarMaPhieuDct.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaPhieuDct);
				
				TableSchema.TableColumn colvarMaLuotkham = new TableSchema.TableColumn(schema);
				colvarMaLuotkham.ColumnName = "ma_luotkham";
				colvarMaLuotkham.DataType = DbType.String;
				colvarMaLuotkham.MaxLength = 20;
				colvarMaLuotkham.AutoIncrement = false;
				colvarMaLuotkham.IsNullable = true;
				colvarMaLuotkham.IsPrimaryKey = false;
				colvarMaLuotkham.IsForeignKey = false;
				colvarMaLuotkham.IsReadOnly = false;
				colvarMaLuotkham.DefaultSetting = @"";
				colvarMaLuotkham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaLuotkham);
				
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
				
				TableSchema.TableColumn colvarTongTien = new TableSchema.TableColumn(schema);
				colvarTongTien.ColumnName = "tong_tien";
				colvarTongTien.DataType = DbType.Decimal;
				colvarTongTien.MaxLength = 0;
				colvarTongTien.AutoIncrement = false;
				colvarTongTien.IsNullable = true;
				colvarTongTien.IsPrimaryKey = false;
				colvarTongTien.IsForeignKey = false;
				colvarTongTien.IsReadOnly = false;
				colvarTongTien.DefaultSetting = @"";
				colvarTongTien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTongTien);
				
				TableSchema.TableColumn colvarBhytChitra = new TableSchema.TableColumn(schema);
				colvarBhytChitra.ColumnName = "bhyt_chitra";
				colvarBhytChitra.DataType = DbType.Decimal;
				colvarBhytChitra.MaxLength = 0;
				colvarBhytChitra.AutoIncrement = false;
				colvarBhytChitra.IsNullable = true;
				colvarBhytChitra.IsPrimaryKey = false;
				colvarBhytChitra.IsForeignKey = false;
				colvarBhytChitra.IsReadOnly = false;
				colvarBhytChitra.DefaultSetting = @"";
				colvarBhytChitra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBhytChitra);
				
				TableSchema.TableColumn colvarBnhanChitra = new TableSchema.TableColumn(schema);
				colvarBnhanChitra.ColumnName = "bnhan_chitra";
				colvarBnhanChitra.DataType = DbType.Decimal;
				colvarBnhanChitra.MaxLength = 0;
				colvarBnhanChitra.AutoIncrement = false;
				colvarBnhanChitra.IsNullable = true;
				colvarBnhanChitra.IsPrimaryKey = false;
				colvarBnhanChitra.IsForeignKey = false;
				colvarBnhanChitra.IsReadOnly = false;
				colvarBnhanChitra.DefaultSetting = @"";
				colvarBnhanChitra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBnhanChitra);
				
				TableSchema.TableColumn colvarNguoiTao = new TableSchema.TableColumn(schema);
				colvarNguoiTao.ColumnName = "nguoi_tao";
				colvarNguoiTao.DataType = DbType.String;
				colvarNguoiTao.MaxLength = 20;
				colvarNguoiTao.AutoIncrement = false;
				colvarNguoiTao.IsNullable = true;
				colvarNguoiTao.IsPrimaryKey = false;
				colvarNguoiTao.IsForeignKey = false;
				colvarNguoiTao.IsReadOnly = false;
				colvarNguoiTao.DefaultSetting = @"";
				colvarNguoiTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTao);
				
				TableSchema.TableColumn colvarNgayTao = new TableSchema.TableColumn(schema);
				colvarNgayTao.ColumnName = "ngay_tao";
				colvarNgayTao.DataType = DbType.DateTime;
				colvarNgayTao.MaxLength = 0;
				colvarNgayTao.AutoIncrement = false;
				colvarNgayTao.IsNullable = true;
				colvarNgayTao.IsPrimaryKey = false;
				colvarNgayTao.IsForeignKey = false;
				colvarNgayTao.IsReadOnly = false;
				
						colvarNgayTao.DefaultSetting = @"(getdate())";
				colvarNgayTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTao);
				
				TableSchema.TableColumn colvarNgaySua = new TableSchema.TableColumn(schema);
				colvarNgaySua.ColumnName = "ngay_sua";
				colvarNgaySua.DataType = DbType.DateTime;
				colvarNgaySua.MaxLength = 0;
				colvarNgaySua.AutoIncrement = false;
				colvarNgaySua.IsNullable = true;
				colvarNgaySua.IsPrimaryKey = false;
				colvarNgaySua.IsForeignKey = false;
				colvarNgaySua.IsReadOnly = false;
				colvarNgaySua.DefaultSetting = @"";
				colvarNgaySua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgaySua);
				
				TableSchema.TableColumn colvarNguoiSua = new TableSchema.TableColumn(schema);
				colvarNguoiSua.ColumnName = "nguoi_sua";
				colvarNguoiSua.DataType = DbType.String;
				colvarNguoiSua.MaxLength = 20;
				colvarNguoiSua.AutoIncrement = false;
				colvarNguoiSua.IsNullable = true;
				colvarNguoiSua.IsPrimaryKey = false;
				colvarNguoiSua.IsForeignKey = false;
				colvarNguoiSua.IsReadOnly = false;
				colvarNguoiSua.DefaultSetting = @"";
				colvarNguoiSua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiSua);
				
				TableSchema.TableColumn colvarLoaiThanhtoan = new TableSchema.TableColumn(schema);
				colvarLoaiThanhtoan.ColumnName = "loai_thanhtoan";
				colvarLoaiThanhtoan.DataType = DbType.Byte;
				colvarLoaiThanhtoan.MaxLength = 0;
				colvarLoaiThanhtoan.AutoIncrement = false;
				colvarLoaiThanhtoan.IsNullable = true;
				colvarLoaiThanhtoan.IsPrimaryKey = false;
				colvarLoaiThanhtoan.IsForeignKey = false;
				colvarLoaiThanhtoan.IsReadOnly = false;
				
						colvarLoaiThanhtoan.DefaultSetting = @"((0))";
				colvarLoaiThanhtoan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoaiThanhtoan);
				
				TableSchema.TableColumn colvarMaKhoaThuchien = new TableSchema.TableColumn(schema);
				colvarMaKhoaThuchien.ColumnName = "ma_khoa_thuchien";
				colvarMaKhoaThuchien.DataType = DbType.String;
				colvarMaKhoaThuchien.MaxLength = 10;
				colvarMaKhoaThuchien.AutoIncrement = false;
				colvarMaKhoaThuchien.IsNullable = true;
				colvarMaKhoaThuchien.IsPrimaryKey = false;
				colvarMaKhoaThuchien.IsForeignKey = false;
				colvarMaKhoaThuchien.IsReadOnly = false;
				colvarMaKhoaThuchien.DefaultSetting = @"";
				colvarMaKhoaThuchien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaKhoaThuchien);
				
				TableSchema.TableColumn colvarTenLoaithanhtoan = new TableSchema.TableColumn(schema);
				colvarTenLoaithanhtoan.ColumnName = "ten_loaithanhtoan";
				colvarTenLoaithanhtoan.DataType = DbType.String;
				colvarTenLoaithanhtoan.MaxLength = 30;
				colvarTenLoaithanhtoan.AutoIncrement = false;
				colvarTenLoaithanhtoan.IsNullable = true;
				colvarTenLoaithanhtoan.IsPrimaryKey = false;
				colvarTenLoaithanhtoan.IsForeignKey = false;
				colvarTenLoaithanhtoan.IsReadOnly = false;
				colvarTenLoaithanhtoan.DefaultSetting = @"";
				colvarTenLoaithanhtoan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenLoaithanhtoan);
				
				TableSchema.TableColumn colvarIpMaytao = new TableSchema.TableColumn(schema);
				colvarIpMaytao.ColumnName = "ip_maytao";
				colvarIpMaytao.DataType = DbType.String;
				colvarIpMaytao.MaxLength = 30;
				colvarIpMaytao.AutoIncrement = false;
				colvarIpMaytao.IsNullable = true;
				colvarIpMaytao.IsPrimaryKey = false;
				colvarIpMaytao.IsForeignKey = false;
				colvarIpMaytao.IsReadOnly = false;
				colvarIpMaytao.DefaultSetting = @"";
				colvarIpMaytao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIpMaytao);
				
				TableSchema.TableColumn colvarIpMaysua = new TableSchema.TableColumn(schema);
				colvarIpMaysua.ColumnName = "ip_maysua";
				colvarIpMaysua.DataType = DbType.String;
				colvarIpMaysua.MaxLength = 30;
				colvarIpMaysua.AutoIncrement = false;
				colvarIpMaysua.IsNullable = true;
				colvarIpMaysua.IsPrimaryKey = false;
				colvarIpMaysua.IsForeignKey = false;
				colvarIpMaysua.IsReadOnly = false;
				colvarIpMaysua.DefaultSetting = @"";
				colvarIpMaysua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIpMaysua);
				
				TableSchema.TableColumn colvarTenMaytao = new TableSchema.TableColumn(schema);
				colvarTenMaytao.ColumnName = "ten_maytao";
				colvarTenMaytao.DataType = DbType.String;
				colvarTenMaytao.MaxLength = 100;
				colvarTenMaytao.AutoIncrement = false;
				colvarTenMaytao.IsNullable = true;
				colvarTenMaytao.IsPrimaryKey = false;
				colvarTenMaytao.IsForeignKey = false;
				colvarTenMaytao.IsReadOnly = false;
				colvarTenMaytao.DefaultSetting = @"";
				colvarTenMaytao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenMaytao);
				
				TableSchema.TableColumn colvarTenMaysua = new TableSchema.TableColumn(schema);
				colvarTenMaysua.ColumnName = "ten_maysua";
				colvarTenMaysua.DataType = DbType.String;
				colvarTenMaysua.MaxLength = 100;
				colvarTenMaysua.AutoIncrement = false;
				colvarTenMaysua.IsNullable = true;
				colvarTenMaysua.IsPrimaryKey = false;
				colvarTenMaysua.IsForeignKey = false;
				colvarTenMaysua.IsReadOnly = false;
				colvarTenMaysua.DefaultSetting = @"";
				colvarTenMaysua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenMaysua);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("kcb_phieu_dct",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPhieuDct")]
		[Bindable(true)]
		public int IdPhieuDct 
		{
			get { return GetColumnValue<int>(Columns.IdPhieuDct); }
			set { SetColumnValue(Columns.IdPhieuDct, value); }
		}
		  
		[XmlAttribute("MaPhieuDct")]
		[Bindable(true)]
		public string MaPhieuDct 
		{
			get { return GetColumnValue<string>(Columns.MaPhieuDct); }
			set { SetColumnValue(Columns.MaPhieuDct, value); }
		}
		  
		[XmlAttribute("MaLuotkham")]
		[Bindable(true)]
		public string MaLuotkham 
		{
			get { return GetColumnValue<string>(Columns.MaLuotkham); }
			set { SetColumnValue(Columns.MaLuotkham, value); }
		}
		  
		[XmlAttribute("IdBenhnhan")]
		[Bindable(true)]
		public int? IdBenhnhan 
		{
			get { return GetColumnValue<int?>(Columns.IdBenhnhan); }
			set { SetColumnValue(Columns.IdBenhnhan, value); }
		}
		  
		[XmlAttribute("TongTien")]
		[Bindable(true)]
		public decimal? TongTien 
		{
			get { return GetColumnValue<decimal?>(Columns.TongTien); }
			set { SetColumnValue(Columns.TongTien, value); }
		}
		  
		[XmlAttribute("BhytChitra")]
		[Bindable(true)]
		public decimal? BhytChitra 
		{
			get { return GetColumnValue<decimal?>(Columns.BhytChitra); }
			set { SetColumnValue(Columns.BhytChitra, value); }
		}
		  
		[XmlAttribute("BnhanChitra")]
		[Bindable(true)]
		public decimal? BnhanChitra 
		{
			get { return GetColumnValue<decimal?>(Columns.BnhanChitra); }
			set { SetColumnValue(Columns.BnhanChitra, value); }
		}
		  
		[XmlAttribute("NguoiTao")]
		[Bindable(true)]
		public string NguoiTao 
		{
			get { return GetColumnValue<string>(Columns.NguoiTao); }
			set { SetColumnValue(Columns.NguoiTao, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime? NgayTao 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("NgaySua")]
		[Bindable(true)]
		public DateTime? NgaySua 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgaySua); }
			set { SetColumnValue(Columns.NgaySua, value); }
		}
		  
		[XmlAttribute("NguoiSua")]
		[Bindable(true)]
		public string NguoiSua 
		{
			get { return GetColumnValue<string>(Columns.NguoiSua); }
			set { SetColumnValue(Columns.NguoiSua, value); }
		}
		  
		[XmlAttribute("LoaiThanhtoan")]
		[Bindable(true)]
		public byte? LoaiThanhtoan 
		{
			get { return GetColumnValue<byte?>(Columns.LoaiThanhtoan); }
			set { SetColumnValue(Columns.LoaiThanhtoan, value); }
		}
		  
		[XmlAttribute("MaKhoaThuchien")]
		[Bindable(true)]
		public string MaKhoaThuchien 
		{
			get { return GetColumnValue<string>(Columns.MaKhoaThuchien); }
			set { SetColumnValue(Columns.MaKhoaThuchien, value); }
		}
		  
		[XmlAttribute("TenLoaithanhtoan")]
		[Bindable(true)]
		public string TenLoaithanhtoan 
		{
			get { return GetColumnValue<string>(Columns.TenLoaithanhtoan); }
			set { SetColumnValue(Columns.TenLoaithanhtoan, value); }
		}
		  
		[XmlAttribute("IpMaytao")]
		[Bindable(true)]
		public string IpMaytao 
		{
			get { return GetColumnValue<string>(Columns.IpMaytao); }
			set { SetColumnValue(Columns.IpMaytao, value); }
		}
		  
		[XmlAttribute("IpMaysua")]
		[Bindable(true)]
		public string IpMaysua 
		{
			get { return GetColumnValue<string>(Columns.IpMaysua); }
			set { SetColumnValue(Columns.IpMaysua, value); }
		}
		  
		[XmlAttribute("TenMaytao")]
		[Bindable(true)]
		public string TenMaytao 
		{
			get { return GetColumnValue<string>(Columns.TenMaytao); }
			set { SetColumnValue(Columns.TenMaytao, value); }
		}
		  
		[XmlAttribute("TenMaysua")]
		[Bindable(true)]
		public string TenMaysua 
		{
			get { return GetColumnValue<string>(Columns.TenMaysua); }
			set { SetColumnValue(Columns.TenMaysua, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMaPhieuDct,string varMaLuotkham,int? varIdBenhnhan,decimal? varTongTien,decimal? varBhytChitra,decimal? varBnhanChitra,string varNguoiTao,DateTime? varNgayTao,DateTime? varNgaySua,string varNguoiSua,byte? varLoaiThanhtoan,string varMaKhoaThuchien,string varTenLoaithanhtoan,string varIpMaytao,string varIpMaysua,string varTenMaytao,string varTenMaysua)
		{
			KcbPhieuDct item = new KcbPhieuDct();
			
			item.MaPhieuDct = varMaPhieuDct;
			
			item.MaLuotkham = varMaLuotkham;
			
			item.IdBenhnhan = varIdBenhnhan;
			
			item.TongTien = varTongTien;
			
			item.BhytChitra = varBhytChitra;
			
			item.BnhanChitra = varBnhanChitra;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayTao = varNgayTao;
			
			item.NgaySua = varNgaySua;
			
			item.NguoiSua = varNguoiSua;
			
			item.LoaiThanhtoan = varLoaiThanhtoan;
			
			item.MaKhoaThuchien = varMaKhoaThuchien;
			
			item.TenLoaithanhtoan = varTenLoaithanhtoan;
			
			item.IpMaytao = varIpMaytao;
			
			item.IpMaysua = varIpMaysua;
			
			item.TenMaytao = varTenMaytao;
			
			item.TenMaysua = varTenMaysua;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPhieuDct,string varMaPhieuDct,string varMaLuotkham,int? varIdBenhnhan,decimal? varTongTien,decimal? varBhytChitra,decimal? varBnhanChitra,string varNguoiTao,DateTime? varNgayTao,DateTime? varNgaySua,string varNguoiSua,byte? varLoaiThanhtoan,string varMaKhoaThuchien,string varTenLoaithanhtoan,string varIpMaytao,string varIpMaysua,string varTenMaytao,string varTenMaysua)
		{
			KcbPhieuDct item = new KcbPhieuDct();
			
				item.IdPhieuDct = varIdPhieuDct;
			
				item.MaPhieuDct = varMaPhieuDct;
			
				item.MaLuotkham = varMaLuotkham;
			
				item.IdBenhnhan = varIdBenhnhan;
			
				item.TongTien = varTongTien;
			
				item.BhytChitra = varBhytChitra;
			
				item.BnhanChitra = varBnhanChitra;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayTao = varNgayTao;
			
				item.NgaySua = varNgaySua;
			
				item.NguoiSua = varNguoiSua;
			
				item.LoaiThanhtoan = varLoaiThanhtoan;
			
				item.MaKhoaThuchien = varMaKhoaThuchien;
			
				item.TenLoaithanhtoan = varTenLoaithanhtoan;
			
				item.IpMaytao = varIpMaytao;
			
				item.IpMaysua = varIpMaysua;
			
				item.TenMaytao = varTenMaytao;
			
				item.TenMaysua = varTenMaysua;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPhieuDctColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MaPhieuDctColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MaLuotkhamColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBenhnhanColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TongTienColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn BhytChitraColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BnhanChitraColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySuaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiSuaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn LoaiThanhtoanColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MaKhoaThuchienColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TenLoaithanhtoanColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IpMaytaoColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IpMaysuaColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn TenMaytaoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn TenMaysuaColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPhieuDct = @"id_phieu_dct";
			 public static string MaPhieuDct = @"ma_phieu_dct";
			 public static string MaLuotkham = @"ma_luotkham";
			 public static string IdBenhnhan = @"id_benhnhan";
			 public static string TongTien = @"tong_tien";
			 public static string BhytChitra = @"bhyt_chitra";
			 public static string BnhanChitra = @"bnhan_chitra";
			 public static string NguoiTao = @"nguoi_tao";
			 public static string NgayTao = @"ngay_tao";
			 public static string NgaySua = @"ngay_sua";
			 public static string NguoiSua = @"nguoi_sua";
			 public static string LoaiThanhtoan = @"loai_thanhtoan";
			 public static string MaKhoaThuchien = @"ma_khoa_thuchien";
			 public static string TenLoaithanhtoan = @"ten_loaithanhtoan";
			 public static string IpMaytao = @"ip_maytao";
			 public static string IpMaysua = @"ip_maysua";
			 public static string TenMaytao = @"ten_maytao";
			 public static string TenMaysua = @"ten_maysua";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
