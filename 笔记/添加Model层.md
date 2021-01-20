## 前置知识
---
* 使用分层结构完成项目，单独分出Model层用于API项目的复用。
* 使用Attribute限制字段的数据类型用于后期前端、后端的验证
    * Require 限制该字段不能为null
    * MinLength MaxLength 限制字段长度，固定长度用 StringLength
    * DataType 限制数据类型，DateType.Date 限制保存日期不保存时间
* 使用基类添加需要重复使用的字段
    * 父类字段用 virtual 修饰用于子类的重载
    * 问题：重载与隐藏的区别？
## 添加登录、注册用的Model及其基类
--- 
```C#
    public class SignBase {
        [Required, MinLength(4), MaxLength(24)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(6)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
    }


    public class Login : SignBase {
        [MaxLength(24), MinLength(4)]
        public new string Name { get; set; }
    }


    public class Register : SignBase {

    }
```

## 添加实体Model及其基类
---
```C#
    public class EntityBase {
        public int ID { get; set; }
        [Required]
        public virtual string Name { get; set; }
    }

    public class Customer : EntityBase{
        [Required, MinLength(4), MaxLength(24)]
        public override string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(6)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
        public Role Role { get; set; }
    }

    public class DataRecord {
        public int ID { get; set; }
        [Required]
        public virtual Production Production { get; set; }
        public virtual Property Property { get; set; }
    }

    public class Production :EntityBase{
        public virtual Region Region { get; set; }
        public virtual List<DataRecord> DataRecords { get; set; }
    }

    public class Property :EntityBase{

    }

    public class Region :EntityBase{
        [DataType(DataType.Date)]
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public string Address { get; set; }
        public virtual List<Production> Productions { get; set; }
    }

    public class Role : EntityBase {
        public override string Name { get; set; } = "customer";
    }
```