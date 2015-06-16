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
	/// Strongly-typed collection for the KcbDanhsachBenhnhan class.
	/// </summary>
    [Serializable]
	public partial class KcbDanhsachBenhnhanCollection : ActiveList<KcbDanhsachBenhnhan, KcbDanhsachBenhnhanCollection>
	{	   
		public KcbDanhsachBenhnhanCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>KcbDanhsachBenhnhanCollection</returns>
		public KcbDanhsachBenhnhanCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                KcbDanhsachBenhnhan o = this[i];
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
	/// This is an ActiveRecord class which wraps the kcb_danhsach_benhnhan table.
	/// </summary>
	[Serializable]
	public partial class KcbDanhsachBenhnhan : ActiveRecord<KcbDanhsachBenhnhan>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public KcbDanhsachBenhnhan()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public KcbDanhsachBenhnhan(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public KcbDanhsachBenhnhan(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public KcbDanhsachBenhnhan(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("kcb_danhsach_benhnhan", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdBenhnhan = new TableSchema.TableColumn(schema);
				colvarIdBenhnhan.ColumnName = "id_benhnhan";
				colvarIdBenhnhan.DataType = DbType.Int64;
				colvarIdBenhnhan.MaxLength = 0;
				colvarIdBenhnhan.AutoIncrement = true;
				colvarIdBenhnhan.IsNullable = false;
				colvarIdBenhnhan.IsPrimaryKey = true;
				colvarIdBenhnhan.IsForeignKey = false;
				colvarIdBenhnhan.IsReadOnly = false;
				colvarIdBenhnhan.DefaultSetting = @"";
				colvarIdBenhnhan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBenhnhan);
				
				TableSchema.TableColumn colvarTenBenhnhan = new TableSchema.TableColumn(schema);
				colvarTenBenhnhan.ColumnName = "ten_benhnhan";
				colvarTenBenhnhan.DataType = DbType.String;
				colvarTenBenhnhan.MaxLength = 100;
				colvarTenBenhnhan.AutoIncrement = false;
				colvarTenBenhnhan.IsNullable = true;
				colvarTenBenhnhan.IsPrimaryKey = false;
				colvarTenBenhnhan.IsForeignKey = false;
				colvarTenBenhnhan.IsReadOnly = false;
				colvarTenBenhnhan.DefaultSetting = @"";
				colvarTenBenhnhan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenBenhnhan);
				
				TableSchema.TableColumn colvarDiaChi = new TableSchema.TableColumn(schema);
				colvarDiaChi.ColumnName = "dia_chi";
				colvarDiaChi.DataType = DbType.String;
				colvarDiaChi.MaxLength = 200;
				colvarDiaChi.AutoIncrement = false;
				colvarDiaChi.IsNullable = true;
				colvarDiaChi.IsPrimaryKey = false;
				colvarDiaChi.IsForeignKey = false;
				colvarDiaChi.IsReadOnly = false;
				colvarDiaChi.DefaultSetting = @"";
				colvarDiaChi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiaChi);
				
				TableSchema.TableColumn colvarMaTinhThanhpho = new TableSchema.TableColumn(schema);
				colvarMaTinhThanhpho.ColumnName = "ma_tinh_thanhpho";
				colvarMaTinhThanhpho.DataType = DbType.AnsiString;
				colvarMaTinhThanhpho.MaxLength = 50;
				colvarMaTinhThanhpho.AutoIncrement = false;
				colvarMaTinhThanhpho.IsNullable = true;
				colvarMaTinhThanhpho.IsPrimaryKey = false;
				colvarMaTinhThanhpho.IsForeignKey = false;
				colvarMaTinhThanhpho.IsReadOnly = false;
				colvarMaTinhThanhpho.DefaultSetting = @"";
				colvarMaTinhThanhpho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaTinhThanhpho);
				
				TableSchema.TableColumn colvarMaQuanhuyen = new TableSchema.TableColumn(schema);
				colvarMaQuanhuyen.ColumnName = "ma_quanhuyen";
				colvarMaQuanhuyen.DataType = DbType.AnsiString;
				colvarMaQuanhuyen.MaxLength = 50;
				colvarMaQuanhuyen.AutoIncrement = false;
				colvarMaQuanhuyen.IsNullable = true;
				colvarMaQuanhuyen.IsPrimaryKey = false;
				colvarMaQuanhuyen.IsForeignKey = false;
				colvarMaQuanhuyen.IsReadOnly = false;
				colvarMaQuanhuyen.DefaultSetting = @"";
				colvarMaQuanhuyen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaQuanhuyen);
				
				TableSchema.TableColumn colvarNgaySinh = new TableSchema.TableColumn(schema);
				colvarNgaySinh.ColumnName = "ngay_sinh";
				colvarNgaySinh.DataType = DbType.DateTime;
				colvarNgaySinh.MaxLength = 0;
				colvarNgaySinh.AutoIncrement = false;
				colvarNgaySinh.IsNullable = true;
				colvarNgaySinh.IsPrimaryKey = false;
				colvarNgaySinh.IsForeignKey = false;
				colvarNgaySinh.IsReadOnly = false;
				colvarNgaySinh.DefaultSetting = @"";
				colvarNgaySinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgaySinh);
				
				TableSchema.TableColumn colvarNamSinh = new TableSchema.TableColumn(schema);
				colvarNamSinh.ColumnName = "nam_sinh";
				colvarNamSinh.DataType = DbType.Int16;
				colvarNamSinh.MaxLength = 0;
				colvarNamSinh.AutoIncrement = false;
				colvarNamSinh.IsNullable = true;
				colvarNamSinh.IsPrimaryKey = false;
				colvarNamSinh.IsForeignKey = false;
				colvarNamSinh.IsReadOnly = false;
				colvarNamSinh.DefaultSetting = @"";
				colvarNamSinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNamSinh);
				
				TableSchema.TableColumn colvarIdGioitinh = new TableSchema.TableColumn(schema);
				colvarIdGioitinh.ColumnName = "id_gioitinh";
				colvarIdGioitinh.DataType = DbType.Byte;
				colvarIdGioitinh.MaxLength = 0;
				colvarIdGioitinh.AutoIncrement = false;
				colvarIdGioitinh.IsNullable = true;
				colvarIdGioitinh.IsPrimaryKey = false;
				colvarIdGioitinh.IsForeignKey = false;
				colvarIdGioitinh.IsReadOnly = false;
				colvarIdGioitinh.DefaultSetting = @"";
				colvarIdGioitinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdGioitinh);
				
				TableSchema.TableColumn colvarGioiTinh = new TableSchema.TableColumn(schema);
				colvarGioiTinh.ColumnName = "gioi_tinh";
				colvarGioiTinh.DataType = DbType.String;
				colvarGioiTinh.MaxLength = 5;
				colvarGioiTinh.AutoIncrement = false;
				colvarGioiTinh.IsNullable = false;
				colvarGioiTinh.IsPrimaryKey = false;
				colvarGioiTinh.IsForeignKey = false;
				colvarGioiTinh.IsReadOnly = false;
				colvarGioiTinh.DefaultSetting = @"";
				colvarGioiTinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGioiTinh);
				
				TableSchema.TableColumn colvarNgheNghiep = new TableSchema.TableColumn(schema);
				colvarNgheNghiep.ColumnName = "nghe_nghiep";
				colvarNgheNghiep.DataType = DbType.String;
				colvarNgheNghiep.MaxLength = 100;
				colvarNgheNghiep.AutoIncrement = false;
				colvarNgheNghiep.IsNullable = true;
				colvarNgheNghiep.IsPrimaryKey = false;
				colvarNgheNghiep.IsForeignKey = false;
				colvarNgheNghiep.IsReadOnly = false;
				colvarNgheNghiep.DefaultSetting = @"";
				colvarNgheNghiep.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgheNghiep);
				
				TableSchema.TableColumn colvarCoQuan = new TableSchema.TableColumn(schema);
				colvarCoQuan.ColumnName = "co_quan";
				colvarCoQuan.DataType = DbType.String;
				colvarCoQuan.MaxLength = 100;
				colvarCoQuan.AutoIncrement = false;
				colvarCoQuan.IsNullable = true;
				colvarCoQuan.IsPrimaryKey = false;
				colvarCoQuan.IsForeignKey = false;
				colvarCoQuan.IsReadOnly = false;
				colvarCoQuan.DefaultSetting = @"";
				colvarCoQuan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoQuan);
				
				TableSchema.TableColumn colvarCmt = new TableSchema.TableColumn(schema);
				colvarCmt.ColumnName = "CMT";
				colvarCmt.DataType = DbType.String;
				colvarCmt.MaxLength = 30;
				colvarCmt.AutoIncrement = false;
				colvarCmt.IsNullable = true;
				colvarCmt.IsPrimaryKey = false;
				colvarCmt.IsForeignKey = false;
				colvarCmt.IsReadOnly = false;
				colvarCmt.DefaultSetting = @"";
				colvarCmt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCmt);
				
				TableSchema.TableColumn colvarMaQuocgia = new TableSchema.TableColumn(schema);
				colvarMaQuocgia.ColumnName = "ma_quocgia";
				colvarMaQuocgia.DataType = DbType.Int16;
				colvarMaQuocgia.MaxLength = 0;
				colvarMaQuocgia.AutoIncrement = false;
				colvarMaQuocgia.IsNullable = true;
				colvarMaQuocgia.IsPrimaryKey = false;
				colvarMaQuocgia.IsForeignKey = false;
				colvarMaQuocgia.IsReadOnly = false;
				colvarMaQuocgia.DefaultSetting = @"";
				colvarMaQuocgia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaQuocgia);
				
				TableSchema.TableColumn colvarDienThoai = new TableSchema.TableColumn(schema);
				colvarDienThoai.ColumnName = "dien_thoai";
				colvarDienThoai.DataType = DbType.String;
				colvarDienThoai.MaxLength = 50;
				colvarDienThoai.AutoIncrement = false;
				colvarDienThoai.IsNullable = true;
				colvarDienThoai.IsPrimaryKey = false;
				colvarDienThoai.IsForeignKey = false;
				colvarDienThoai.IsReadOnly = false;
				colvarDienThoai.DefaultSetting = @"";
				colvarDienThoai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDienThoai);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "email";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 50;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = true;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
				TableSchema.TableColumn colvarNgayTiepdon = new TableSchema.TableColumn(schema);
				colvarNgayTiepdon.ColumnName = "ngay_tiepdon";
				colvarNgayTiepdon.DataType = DbType.DateTime;
				colvarNgayTiepdon.MaxLength = 0;
				colvarNgayTiepdon.AutoIncrement = false;
				colvarNgayTiepdon.IsNullable = false;
				colvarNgayTiepdon.IsPrimaryKey = false;
				colvarNgayTiepdon.IsForeignKey = false;
				colvarNgayTiepdon.IsReadOnly = false;
				
						colvarNgayTiepdon.DefaultSetting = @"(getdate())";
				colvarNgayTiepdon.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTiepdon);
				
				TableSchema.TableColumn colvarNguoiTiepdon = new TableSchema.TableColumn(schema);
				colvarNguoiTiepdon.ColumnName = "nguoi_tiepdon";
				colvarNguoiTiepdon.DataType = DbType.String;
				colvarNguoiTiepdon.MaxLength = 50;
				colvarNguoiTiepdon.AutoIncrement = false;
				colvarNguoiTiepdon.IsNullable = false;
				colvarNguoiTiepdon.IsPrimaryKey = false;
				colvarNguoiTiepdon.IsForeignKey = false;
				colvarNguoiTiepdon.IsReadOnly = false;
				colvarNguoiTiepdon.DefaultSetting = @"";
				colvarNguoiTiepdon.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTiepdon);
				
				TableSchema.TableColumn colvarDanToc = new TableSchema.TableColumn(schema);
				colvarDanToc.ColumnName = "dan_toc";
				colvarDanToc.DataType = DbType.String;
				colvarDanToc.MaxLength = 50;
				colvarDanToc.AutoIncrement = false;
				colvarDanToc.IsNullable = true;
				colvarDanToc.IsPrimaryKey = false;
				colvarDanToc.IsForeignKey = false;
				colvarDanToc.IsReadOnly = false;
				colvarDanToc.DefaultSetting = @"";
				colvarDanToc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDanToc);
				
				TableSchema.TableColumn colvarTonGiao = new TableSchema.TableColumn(schema);
				colvarTonGiao.ColumnName = "ton_giao";
				colvarTonGiao.DataType = DbType.String;
				colvarTonGiao.MaxLength = 50;
				colvarTonGiao.AutoIncrement = false;
				colvarTonGiao.IsNullable = true;
				colvarTonGiao.IsPrimaryKey = false;
				colvarTonGiao.IsForeignKey = false;
				colvarTonGiao.IsReadOnly = false;
				colvarTonGiao.DefaultSetting = @"";
				colvarTonGiao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTonGiao);
				
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
				
				TableSchema.TableColumn colvarNguoiSua = new TableSchema.TableColumn(schema);
				colvarNguoiSua.ColumnName = "nguoi_sua";
				colvarNguoiSua.DataType = DbType.String;
				colvarNguoiSua.MaxLength = 50;
				colvarNguoiSua.AutoIncrement = false;
				colvarNguoiSua.IsNullable = true;
				colvarNguoiSua.IsPrimaryKey = false;
				colvarNguoiSua.IsForeignKey = false;
				colvarNguoiSua.IsReadOnly = false;
				colvarNguoiSua.DefaultSetting = @"";
				colvarNguoiSua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiSua);
				
				TableSchema.TableColumn colvarNguoiTao = new TableSchema.TableColumn(schema);
				colvarNguoiTao.ColumnName = "nguoi_tao";
				colvarNguoiTao.DataType = DbType.String;
				colvarNguoiTao.MaxLength = 50;
				colvarNguoiTao.AutoIncrement = false;
				colvarNguoiTao.IsNullable = true;
				colvarNguoiTao.IsPrimaryKey = false;
				colvarNguoiTao.IsForeignKey = false;
				colvarNguoiTao.IsReadOnly = false;
				colvarNguoiTao.DefaultSetting = @"";
				colvarNguoiTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTao);
				
				TableSchema.TableColumn colvarDiachiBhyt = new TableSchema.TableColumn(schema);
				colvarDiachiBhyt.ColumnName = "diachi_bhyt";
				colvarDiachiBhyt.DataType = DbType.String;
				colvarDiachiBhyt.MaxLength = 500;
				colvarDiachiBhyt.AutoIncrement = false;
				colvarDiachiBhyt.IsNullable = true;
				colvarDiachiBhyt.IsPrimaryKey = false;
				colvarDiachiBhyt.IsForeignKey = false;
				colvarDiachiBhyt.IsReadOnly = false;
				colvarDiachiBhyt.DefaultSetting = @"";
				colvarDiachiBhyt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiachiBhyt);
				
				TableSchema.TableColumn colvarNguonGoc = new TableSchema.TableColumn(schema);
				colvarNguonGoc.ColumnName = "nguon_goc";
				colvarNguonGoc.DataType = DbType.String;
				colvarNguonGoc.MaxLength = 10;
				colvarNguonGoc.AutoIncrement = false;
				colvarNguonGoc.IsNullable = true;
				colvarNguonGoc.IsPrimaryKey = false;
				colvarNguonGoc.IsForeignKey = false;
				colvarNguonGoc.IsReadOnly = false;
				colvarNguonGoc.DefaultSetting = @"";
				colvarNguonGoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguonGoc);
				
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
				DataService.Providers["ORM"].AddSchema("kcb_danhsach_benhnhan",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdBenhnhan")]
		[Bindable(true)]
		public long IdBenhnhan 
		{
			get { return GetColumnValue<long>(Columns.IdBenhnhan); }
			set { SetColumnValue(Columns.IdBenhnhan, value); }
		}
		  
		[XmlAttribute("TenBenhnhan")]
		[Bindable(true)]
		public string TenBenhnhan 
		{
			get { return GetColumnValue<string>(Columns.TenBenhnhan); }
			set { SetColumnValue(Columns.TenBenhnhan, value); }
		}
		  
		[XmlAttribute("DiaChi")]
		[Bindable(true)]
		public string DiaChi 
		{
			get { return GetColumnValue<string>(Columns.DiaChi); }
			set { SetColumnValue(Columns.DiaChi, value); }
		}
		  
		[XmlAttribute("MaTinhThanhpho")]
		[Bindable(true)]
		public string MaTinhThanhpho 
		{
			get { return GetColumnValue<string>(Columns.MaTinhThanhpho); }
			set { SetColumnValue(Columns.MaTinhThanhpho, value); }
		}
		  
		[XmlAttribute("MaQuanhuyen")]
		[Bindable(true)]
		public string MaQuanhuyen 
		{
			get { return GetColumnValue<string>(Columns.MaQuanhuyen); }
			set { SetColumnValue(Columns.MaQuanhuyen, value); }
		}
		  
		[XmlAttribute("NgaySinh")]
		[Bindable(true)]
		public DateTime? NgaySinh 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgaySinh); }
			set { SetColumnValue(Columns.NgaySinh, value); }
		}
		  
		[XmlAttribute("NamSinh")]
		[Bindable(true)]
		public short? NamSinh 
		{
			get { return GetColumnValue<short?>(Columns.NamSinh); }
			set { SetColumnValue(Columns.NamSinh, value); }
		}
		  
		[XmlAttribute("IdGioitinh")]
		[Bindable(true)]
		public byte? IdGioitinh 
		{
			get { return GetColumnValue<byte?>(Columns.IdGioitinh); }
			set { SetColumnValue(Columns.IdGioitinh, value); }
		}
		  
		[XmlAttribute("GioiTinh")]
		[Bindable(true)]
		public string GioiTinh 
		{
			get { return GetColumnValue<string>(Columns.GioiTinh); }
			set { SetColumnValue(Columns.GioiTinh, value); }
		}
		  
		[XmlAttribute("NgheNghiep")]
		[Bindable(true)]
		public string NgheNghiep 
		{
			get { return GetColumnValue<string>(Columns.NgheNghiep); }
			set { SetColumnValue(Columns.NgheNghiep, value); }
		}
		  
		[XmlAttribute("CoQuan")]
		[Bindable(true)]
		public string CoQuan 
		{
			get { return GetColumnValue<string>(Columns.CoQuan); }
			set { SetColumnValue(Columns.CoQuan, value); }
		}
		  
		[XmlAttribute("Cmt")]
		[Bindable(true)]
		public string Cmt 
		{
			get { return GetColumnValue<string>(Columns.Cmt); }
			set { SetColumnValue(Columns.Cmt, value); }
		}
		  
		[XmlAttribute("MaQuocgia")]
		[Bindable(true)]
		public short? MaQuocgia 
		{
			get { return GetColumnValue<short?>(Columns.MaQuocgia); }
			set { SetColumnValue(Columns.MaQuocgia, value); }
		}
		  
		[XmlAttribute("DienThoai")]
		[Bindable(true)]
		public string DienThoai 
		{
			get { return GetColumnValue<string>(Columns.DienThoai); }
			set { SetColumnValue(Columns.DienThoai, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		  
		[XmlAttribute("NgayTiepdon")]
		[Bindable(true)]
		public DateTime NgayTiepdon 
		{
			get { return GetColumnValue<DateTime>(Columns.NgayTiepdon); }
			set { SetColumnValue(Columns.NgayTiepdon, value); }
		}
		  
		[XmlAttribute("NguoiTiepdon")]
		[Bindable(true)]
		public string NguoiTiepdon 
		{
			get { return GetColumnValue<string>(Columns.NguoiTiepdon); }
			set { SetColumnValue(Columns.NguoiTiepdon, value); }
		}
		  
		[XmlAttribute("DanToc")]
		[Bindable(true)]
		public string DanToc 
		{
			get { return GetColumnValue<string>(Columns.DanToc); }
			set { SetColumnValue(Columns.DanToc, value); }
		}
		  
		[XmlAttribute("TonGiao")]
		[Bindable(true)]
		public string TonGiao 
		{
			get { return GetColumnValue<string>(Columns.TonGiao); }
			set { SetColumnValue(Columns.TonGiao, value); }
		}
		  
		[XmlAttribute("NgaySua")]
		[Bindable(true)]
		public DateTime? NgaySua 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgaySua); }
			set { SetColumnValue(Columns.NgaySua, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime? NgayTao 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("NguoiSua")]
		[Bindable(true)]
		public string NguoiSua 
		{
			get { return GetColumnValue<string>(Columns.NguoiSua); }
			set { SetColumnValue(Columns.NguoiSua, value); }
		}
		  
		[XmlAttribute("NguoiTao")]
		[Bindable(true)]
		public string NguoiTao 
		{
			get { return GetColumnValue<string>(Columns.NguoiTao); }
			set { SetColumnValue(Columns.NguoiTao, value); }
		}
		  
		[XmlAttribute("DiachiBhyt")]
		[Bindable(true)]
		public string DiachiBhyt 
		{
			get { return GetColumnValue<string>(Columns.DiachiBhyt); }
			set { SetColumnValue(Columns.DiachiBhyt, value); }
		}
		  
		[XmlAttribute("NguonGoc")]
		[Bindable(true)]
		public string NguonGoc 
		{
			get { return GetColumnValue<string>(Columns.NguonGoc); }
			set { SetColumnValue(Columns.NguonGoc, value); }
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
		public static void Insert(string varTenBenhnhan,string varDiaChi,string varMaTinhThanhpho,string varMaQuanhuyen,DateTime? varNgaySinh,short? varNamSinh,byte? varIdGioitinh,string varGioiTinh,string varNgheNghiep,string varCoQuan,string varCmt,short? varMaQuocgia,string varDienThoai,string varEmail,DateTime varNgayTiepdon,string varNguoiTiepdon,string varDanToc,string varTonGiao,DateTime? varNgaySua,DateTime? varNgayTao,string varNguoiSua,string varNguoiTao,string varDiachiBhyt,string varNguonGoc,string varIpMaytao,string varIpMaysua,string varTenMaytao,string varTenMaysua)
		{
			KcbDanhsachBenhnhan item = new KcbDanhsachBenhnhan();
			
			item.TenBenhnhan = varTenBenhnhan;
			
			item.DiaChi = varDiaChi;
			
			item.MaTinhThanhpho = varMaTinhThanhpho;
			
			item.MaQuanhuyen = varMaQuanhuyen;
			
			item.NgaySinh = varNgaySinh;
			
			item.NamSinh = varNamSinh;
			
			item.IdGioitinh = varIdGioitinh;
			
			item.GioiTinh = varGioiTinh;
			
			item.NgheNghiep = varNgheNghiep;
			
			item.CoQuan = varCoQuan;
			
			item.Cmt = varCmt;
			
			item.MaQuocgia = varMaQuocgia;
			
			item.DienThoai = varDienThoai;
			
			item.Email = varEmail;
			
			item.NgayTiepdon = varNgayTiepdon;
			
			item.NguoiTiepdon = varNguoiTiepdon;
			
			item.DanToc = varDanToc;
			
			item.TonGiao = varTonGiao;
			
			item.NgaySua = varNgaySua;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiSua = varNguoiSua;
			
			item.NguoiTao = varNguoiTao;
			
			item.DiachiBhyt = varDiachiBhyt;
			
			item.NguonGoc = varNguonGoc;
			
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
		public static void Update(long varIdBenhnhan,string varTenBenhnhan,string varDiaChi,string varMaTinhThanhpho,string varMaQuanhuyen,DateTime? varNgaySinh,short? varNamSinh,byte? varIdGioitinh,string varGioiTinh,string varNgheNghiep,string varCoQuan,string varCmt,short? varMaQuocgia,string varDienThoai,string varEmail,DateTime varNgayTiepdon,string varNguoiTiepdon,string varDanToc,string varTonGiao,DateTime? varNgaySua,DateTime? varNgayTao,string varNguoiSua,string varNguoiTao,string varDiachiBhyt,string varNguonGoc,string varIpMaytao,string varIpMaysua,string varTenMaytao,string varTenMaysua)
		{
			KcbDanhsachBenhnhan item = new KcbDanhsachBenhnhan();
			
				item.IdBenhnhan = varIdBenhnhan;
			
				item.TenBenhnhan = varTenBenhnhan;
			
				item.DiaChi = varDiaChi;
			
				item.MaTinhThanhpho = varMaTinhThanhpho;
			
				item.MaQuanhuyen = varMaQuanhuyen;
			
				item.NgaySinh = varNgaySinh;
			
				item.NamSinh = varNamSinh;
			
				item.IdGioitinh = varIdGioitinh;
			
				item.GioiTinh = varGioiTinh;
			
				item.NgheNghiep = varNgheNghiep;
			
				item.CoQuan = varCoQuan;
			
				item.Cmt = varCmt;
			
				item.MaQuocgia = varMaQuocgia;
			
				item.DienThoai = varDienThoai;
			
				item.Email = varEmail;
			
				item.NgayTiepdon = varNgayTiepdon;
			
				item.NguoiTiepdon = varNguoiTiepdon;
			
				item.DanToc = varDanToc;
			
				item.TonGiao = varTonGiao;
			
				item.NgaySua = varNgaySua;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiSua = varNguoiSua;
			
				item.NguoiTao = varNguoiTao;
			
				item.DiachiBhyt = varDiachiBhyt;
			
				item.NguonGoc = varNguonGoc;
			
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
        
        
        public static TableSchema.TableColumn IdBenhnhanColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TenBenhnhanColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DiaChiColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn MaTinhThanhphoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MaQuanhuyenColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySinhColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NamSinhColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdGioitinhColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn GioiTinhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NgheNghiepColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn CoQuanColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn CmtColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MaQuocgiaColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn DienThoaiColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTiepdonColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTiepdonColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn DanTocColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn TonGiaoColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySuaColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiSuaColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn DiachiBhytColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn NguonGocColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn IpMaytaoColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn IpMaysuaColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn TenMaytaoColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn TenMaysuaColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdBenhnhan = @"id_benhnhan";
			 public static string TenBenhnhan = @"ten_benhnhan";
			 public static string DiaChi = @"dia_chi";
			 public static string MaTinhThanhpho = @"ma_tinh_thanhpho";
			 public static string MaQuanhuyen = @"ma_quanhuyen";
			 public static string NgaySinh = @"ngay_sinh";
			 public static string NamSinh = @"nam_sinh";
			 public static string IdGioitinh = @"id_gioitinh";
			 public static string GioiTinh = @"gioi_tinh";
			 public static string NgheNghiep = @"nghe_nghiep";
			 public static string CoQuan = @"co_quan";
			 public static string Cmt = @"CMT";
			 public static string MaQuocgia = @"ma_quocgia";
			 public static string DienThoai = @"dien_thoai";
			 public static string Email = @"email";
			 public static string NgayTiepdon = @"ngay_tiepdon";
			 public static string NguoiTiepdon = @"nguoi_tiepdon";
			 public static string DanToc = @"dan_toc";
			 public static string TonGiao = @"ton_giao";
			 public static string NgaySua = @"ngay_sua";
			 public static string NgayTao = @"ngay_tao";
			 public static string NguoiSua = @"nguoi_sua";
			 public static string NguoiTao = @"nguoi_tao";
			 public static string DiachiBhyt = @"diachi_bhyt";
			 public static string NguonGoc = @"nguon_goc";
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
