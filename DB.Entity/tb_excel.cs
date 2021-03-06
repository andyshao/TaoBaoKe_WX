﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     对此文件的更改可能会导致不正确的行为
//     如果重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;
using Dos.ORM.Common;

namespace DB.Entity
{
    /// <summary>
    /// 实体类tb_excel。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("tb_excel")]
    [Serializable]
    public partial class tb_excel : Dos.ORM.Entity
    {
        #region Model
        private string _ID;
        private string _item_id;
        private string _item_name;
        private string _item_img;
        private string _item_lm;
        private string _tk_url;
        private string _item_price;
        private string _item_xl;
        private string _item_dp_name;
        private string _isTmll;
        private string _quan_id;
        private string _quan_count;
        private string _quan_sy;
        private string _quan_price;
        private string _quan_start_time;
        private string _quan_end_time;
        private string _quan_url;
        private string _quan_tg_url;

        /// <summary>
        /// 
        /// </summary>
        [Field("ID")]
        public string ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange("ID");
                this._ID = value;
            }
        }
        /// <summary>
        /// 商品id
        /// </summary>
        [Field("item_id")]
        public string item_id
        {
            get { return _item_id; }
            set
            {
                this.OnPropertyValueChange("item_id");
                this._item_id = value;
            }
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        [Field("item_name")]
        public string item_name
        {
            get { return _item_name; }
            set
            {
                this.OnPropertyValueChange("item_name");
                this._item_name = value;
            }
        }
        /// <summary>
        /// 商品主图
        /// </summary>
        [Field("item_img")]
        public string item_img
        {
            get { return _item_img; }
            set
            {
                this.OnPropertyValueChange("item_img");
                this._item_img = value;
            }
        }
        /// <summary>
        /// 商品类目
        /// </summary>
        [Field("item_lm")]
        public string item_lm
        {
            get { return _item_lm; }
            set
            {
                this.OnPropertyValueChange("item_lm");
                this._item_lm = value;
            }
        }
        /// <summary>
        /// 淘客链接
        /// </summary>
        [Field("tk_url")]
        public string tk_url
        {
            get { return _tk_url; }
            set
            {
                this.OnPropertyValueChange("tk_url");
                this._tk_url = value;
            }
        }
        /// <summary>
        /// 商品价格
        /// </summary>
        [Field("item_price")]
        public string item_price
        {
            get { return _item_price; }
            set
            {
                this.OnPropertyValueChange("item_price");
                this._item_price = value;
            }
        }
        /// <summary>
        /// 销量
        /// </summary>
        [Field("item_xl")]
        public string item_xl
        {
            get { return _item_xl; }
            set
            {
                this.OnPropertyValueChange("item_xl");
                this._item_xl = value;
            }
        }
        /// <summary>
        /// 店铺名称
        /// </summary>
        [Field("item_dp_name")]
        public string item_dp_name
        {
            get { return _item_dp_name; }
            set
            {
                this.OnPropertyValueChange("item_dp_name");
                this._item_dp_name = value;
            }
        }
        /// <summary>
        /// 是否天猫
        /// </summary>
        [Field("isTmll")]
        public string isTmll
        {
            get { return _isTmll; }
            set
            {
                this.OnPropertyValueChange("isTmll");
                this._isTmll = value;
            }
        }
        /// <summary>
        /// 优惠券id
        /// </summary>
        [Field("quan_id")]
        public string quan_id
        {
            get { return _quan_id; }
            set
            {
                this.OnPropertyValueChange("quan_id");
                this._quan_id = value;
            }
        }
        /// <summary>
        /// 优惠券数量
        /// </summary>
        [Field("quan_count")]
        public string quan_count
        {
            get { return _quan_count; }
            set
            {
                this.OnPropertyValueChange("quan_count");
                this._quan_count = value;
            }
        }
        /// <summary>
        /// 优惠券剩余
        /// </summary>
        [Field("quan_sy")]
        public string quan_sy
        {
            get { return _quan_sy; }
            set
            {
                this.OnPropertyValueChange("quan_sy");
                this._quan_sy = value;
            }
        }
        /// <summary>
        /// 优惠券价格
        /// </summary>
        [Field("quan_price")]
        public string quan_price
        {
            get { return _quan_price; }
            set
            {
                this.OnPropertyValueChange("quan_price");
                this._quan_price = value;
            }
        }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        [Field("quan_start_time")]
        public string quan_start_time
        {
            get { return _quan_start_time; }
            set
            {
                this.OnPropertyValueChange("quan_start_time");
                this._quan_start_time = value;
            }
        }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        [Field("quan_end_time")]
        public string quan_end_time
        {
            get { return _quan_end_time; }
            set
            {
                this.OnPropertyValueChange("quan_end_time");
                this._quan_end_time = value;
            }
        }
        /// <summary>
        /// 优惠券地址
        /// </summary>
        [Field("quan_url")]
        public string quan_url
        {
            get { return _quan_url; }
            set
            {
                this.OnPropertyValueChange("quan_url");
                this._quan_url = value;
            }
        }
        /// <summary>
        /// 优惠券推广地址
        /// </summary>
        [Field("quan_tg_url")]
        public string quan_tg_url
        {
            get { return _quan_tg_url; }
            set
            {
                this.OnPropertyValueChange("quan_tg_url");
                this._quan_tg_url = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                        _.ID,
            };
        }





        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                        _.ID,
                        _.item_id,
                        _.item_name,
                        _.item_img,
                        _.item_lm,
                        _.tk_url,
                        _.item_price,
                        _.item_xl,
                        _.item_dp_name,
                        _.isTmll,
                        _.quan_id,
                        _.quan_count,
                        _.quan_sy,
                        _.quan_price,
                        _.quan_start_time,
                        _.quan_end_time,
                        _.quan_url,
                        _.quan_tg_url,
			};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                        this._ID,
                        this._item_id,
                        this._item_name,
                        this._item_img,
                        this._item_lm,
                        this._tk_url,
                        this._item_price,
                        this._item_xl,
                        this._item_dp_name,
                        this._isTmll,
                        this._quan_id,
                        this._quan_count,
                        this._quan_sy,
                        this._quan_price,
                        this._quan_start_time,
                        this._quan_end_time,
                        this._quan_url,
                        this._quan_tg_url,
			};
        }

        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }

        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "tb_excel");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "tb_excel", "");
            /// <summary>
            /// 商品id
            /// </summary>
            public readonly static Field item_id = new Field("item_id", "tb_excel", "商品id");
            /// <summary>
            /// 商品名称
            /// </summary>
            public readonly static Field item_name = new Field("item_name", "tb_excel", "商品名称");
            /// <summary>
            /// 商品主图
            /// </summary>
            public readonly static Field item_img = new Field("item_img", "tb_excel", "商品主图");
            /// <summary>
            /// 商品类目
            /// </summary>
            public readonly static Field item_lm = new Field("item_lm", "tb_excel", "商品类目");
            /// <summary>
            /// 淘客链接
            /// </summary>
            public readonly static Field tk_url = new Field("tk_url", "tb_excel", "淘客链接");
            /// <summary>
            /// 商品价格
            /// </summary>
            public readonly static Field item_price = new Field("item_price", "tb_excel", "商品价格");
            /// <summary>
            /// 销量
            /// </summary>
            public readonly static Field item_xl = new Field("item_xl", "tb_excel", "销量");
            /// <summary>
            /// 店铺名称
            /// </summary>
            public readonly static Field item_dp_name = new Field("item_dp_name", "tb_excel", "店铺名称");
            /// <summary>
            /// 是否天猫
            /// </summary>
            public readonly static Field isTmll = new Field("isTmll", "tb_excel", "是否天猫");
            /// <summary>
            /// 优惠券id
            /// </summary>
            public readonly static Field quan_id = new Field("quan_id", "tb_excel", "优惠券id");
            /// <summary>
            /// 优惠券数量
            /// </summary>
            public readonly static Field quan_count = new Field("quan_count", "tb_excel", "优惠券数量");
            /// <summary>
            /// 优惠券剩余
            /// </summary>
            public readonly static Field quan_sy = new Field("quan_sy", "tb_excel", "优惠券剩余");
            /// <summary>
            /// 优惠券价格
            /// </summary>
            public readonly static Field quan_price = new Field("quan_price", "tb_excel", "优惠券价格");
            /// <summary>
            /// 优惠券开始时间
            /// </summary>
            public readonly static Field quan_start_time = new Field("quan_start_time", "tb_excel", "优惠券开始时间");
            /// <summary>
            /// 优惠券结束时间
            /// </summary>
            public readonly static Field quan_end_time = new Field("quan_end_time", "tb_excel", "优惠券结束时间");
            /// <summary>
            /// 优惠券地址
            /// </summary>
            public readonly static Field quan_url = new Field("quan_url", "tb_excel", "优惠券地址");
            /// <summary>
            /// 优惠券推广地址
            /// </summary>
            public readonly static Field quan_tg_url = new Field("quan_tg_url", "tb_excel", "优惠券推广地址");
        }
        #endregion
    }
}