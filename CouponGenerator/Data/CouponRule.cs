using System;

namespace CouponGenerator.Data
{
    /// <summary>
    /// 优惠券规则
    /// </summary>
    public class CouponRule
    {
        /// <summary>
        /// 规则名称
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// 券的类型
        /// </summary>
        public CouponRuleType CouponRuleType { get; set; }

        /// <summary>
        /// 适用的对象
        /// </summary>
        public TargetObject TargetObject { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public TermOfValidity TermOfValidity { get; set; } = null!;

        /// <summary>
        /// 规则参数
        /// </summary>
        public string Parameter { get; set; } = null!;

        /// <summary>
        /// 规则描述
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// 规则表达式
        /// </summary>
        public string Expression { get; set; } = null!;

        /// <summary>
        /// 计算表达式
        /// </summary>
        public string EvalExpression { get; set; } = null!;

        /// <summary>
        /// 规则表达式(RulesEngine)
        /// </summary>
        public string RuleExpression { get; set; } = null!;
    }

    /// <summary>
    /// 券的类型
    /// </summary>
    public enum CouponRuleType
    {
        /// <summary>
        /// 满减券
        /// </summary>
        FullCouponReduction = 1,
        /// <summary>
        /// 折扣券
        /// </summary>
        DiscountCoupon
    }

    /// <summary>
    /// 适用的对象
    /// </summary>
    public enum TargetObject
    {
        /// <summary>
        /// 订单
        /// </summary>
        Order = 1,
        /// <summary>
        /// 店铺
        /// </summary>
        Store,
        /// <summary>
        /// 产品
        /// </summary>
        Product
    }

    /// <summary>
    /// 有效期
    /// </summary>
    public class TermOfValidity
    {
        /// <summary>
        /// 无限制
        /// </summary>
        public bool NoLimit { get; set; }

        /// <summary>
        /// 有效时长
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// 有效期单位
        /// </summary>
        public TermOfValidityUnit? TermOfValidityUnit { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        public DateTime? TermOfValidityBeginTime { get; set; }
    }

    /// <summary>
    /// 有效期单位
    /// </summary>
    public enum TermOfValidityUnit
    {
        /// <summary>
        /// 小时
        /// </summary>
        Hour = 1,
        /// <summary>
        /// 天
        /// </summary>
        Day,
        /// <summary>
        /// 月份
        /// </summary>
        Month,
        /// <summary>
        /// 年
        /// </summary>
        Year
    }

    /// <summary>
    /// 适用的时段
    /// </summary>
    public class TimeInterval
    {
        /// <summary>
        /// 无限制
        /// </summary>
        public bool NoLimit { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        public List<int>? Months { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        public List<DayOfWeek>? Weeks { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public TimeIntervalTime? TimeBegin { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public TimeIntervalTime? TimeEnd { get; set; }
    }

    /// <summary>
    /// 时间
    /// </summary>
    public class TimeIntervalTime
    {
        /// <summary>
        /// 时
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// 分
        /// </summary>
        public int Minute { get; set; }

        /// <summary>
        /// 秒
        /// </summary>
        public int Second { get; set; }
    }
}
