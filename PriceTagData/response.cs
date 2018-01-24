
// HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class response
{

   private responseOrder[] orderField;

   /// <remarks/>
   [System.Xml.Serialization.XmlElementAttribute("order")]
   public responseOrder[] order
   {
      get
      {
         return this.orderField;
      }
      set
      {
         this.orderField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrder
{

   private uint idOrderField;

   private bool isBuyerField;

   private responseOrderSeller sellerField;

   private responseOrderBuyer buyerField;

   private responseOrderState stateField;

   private responseOrderShippingMethod shippingMethodField;

   private bool isPresaleField;

   private responseOrderShippingAddress shippingAddressField;

   private byte articleCountField;

   private responseOrderEvaluation evaluationField;

   private responseOrderArticle[] articleField;

   private decimal articleValueField;

   private decimal serviceFeeValueField;

   private bool serviceFeeValueFieldSpecified;

   private decimal totalValueField;

   /// <remarks/>
   public uint idOrder
   {
      get
      {
         return this.idOrderField;
      }
      set
      {
         this.idOrderField = value;
      }
   }

   /// <remarks/>
   public bool isBuyer
   {
      get
      {
         return this.isBuyerField;
      }
      set
      {
         this.isBuyerField = value;
      }
   }

   /// <remarks/>
   public responseOrderSeller seller
   {
      get
      {
         return this.sellerField;
      }
      set
      {
         this.sellerField = value;
      }
   }

   /// <remarks/>
   public responseOrderBuyer buyer
   {
      get
      {
         return this.buyerField;
      }
      set
      {
         this.buyerField = value;
      }
   }

   /// <remarks/>
   public responseOrderState state
   {
      get
      {
         return this.stateField;
      }
      set
      {
         this.stateField = value;
      }
   }

   /// <remarks/>
   public responseOrderShippingMethod shippingMethod
   {
      get
      {
         return this.shippingMethodField;
      }
      set
      {
         this.shippingMethodField = value;
      }
   }

   /// <remarks/>
   public bool isPresale
   {
      get
      {
         return this.isPresaleField;
      }
      set
      {
         this.isPresaleField = value;
      }
   }

   /// <remarks/>
   public responseOrderShippingAddress shippingAddress
   {
      get
      {
         return this.shippingAddressField;
      }
      set
      {
         this.shippingAddressField = value;
      }
   }

   /// <remarks/>
   public byte articleCount
   {
      get
      {
         return this.articleCountField;
      }
      set
      {
         this.articleCountField = value;
      }
   }

   /// <remarks/>
   public responseOrderEvaluation evaluation
   {
      get
      {
         return this.evaluationField;
      }
      set
      {
         this.evaluationField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlElementAttribute("article")]
   public responseOrderArticle[] article
   {
      get
      {
         return this.articleField;
      }
      set
      {
         this.articleField = value;
      }
   }

   /// <remarks/>
   public decimal articleValue
   {
      get
      {
         return this.articleValueField;
      }
      set
      {
         this.articleValueField = value;
      }
   }

   /// <remarks/>
   public decimal serviceFeeValue
   {
      get
      {
         return this.serviceFeeValueField;
      }
      set
      {
         this.serviceFeeValueField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool serviceFeeValueSpecified
   {
      get
      {
         return this.serviceFeeValueFieldSpecified;
      }
      set
      {
         this.serviceFeeValueFieldSpecified = value;
      }
   }

   /// <remarks/>
   public decimal totalValue
   {
      get
      {
         return this.totalValueField;
      }
      set
      {
         this.totalValueField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderSeller
{

   private uint idUserField;

   private string usernameField;

   private string registrationDateField;

   private byte isCommercialField;

   private bool isSellerField;

   private responseOrderSellerName nameField;

   private responseOrderSellerAddress addressField;

   private string phoneField;

   private string emailField;

   private string vatField;

   private string legalInformationField;

   private byte riskGroupField;

   private string lossPercentageField;

   private byte unsentShipmentsField;

   private byte reputationField;

   private byte shipsFastField;

   private uint sellCountField;

   private uint soldItemsField;

   private byte avgShippingTimeField;

   private bool onVacationField;

   /// <remarks/>
   public uint idUser
   {
      get
      {
         return this.idUserField;
      }
      set
      {
         this.idUserField = value;
      }
   }

   /// <remarks/>
   public string username
   {
      get
      {
         return this.usernameField;
      }
      set
      {
         this.usernameField = value;
      }
   }

   /// <remarks/>
   public string registrationDate
   {
      get
      {
         return this.registrationDateField;
      }
      set
      {
         this.registrationDateField = value;
      }
   }

   /// <remarks/>
   public byte isCommercial
   {
      get
      {
         return this.isCommercialField;
      }
      set
      {
         this.isCommercialField = value;
      }
   }

   /// <remarks/>
   public bool isSeller
   {
      get
      {
         return this.isSellerField;
      }
      set
      {
         this.isSellerField = value;
      }
   }

   /// <remarks/>
   public responseOrderSellerName name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public responseOrderSellerAddress address
   {
      get
      {
         return this.addressField;
      }
      set
      {
         this.addressField = value;
      }
   }

   /// <remarks/>
   public string phone
   {
      get
      {
         return this.phoneField;
      }
      set
      {
         this.phoneField = value;
      }
   }

   /// <remarks/>
   public string email
   {
      get
      {
         return this.emailField;
      }
      set
      {
         this.emailField = value;
      }
   }

   /// <remarks/>
   public string vat
   {
      get
      {
         return this.vatField;
      }
      set
      {
         this.vatField = value;
      }
   }

   /// <remarks/>
   public string legalInformation
   {
      get
      {
         return this.legalInformationField;
      }
      set
      {
         this.legalInformationField = value;
      }
   }

   /// <remarks/>
   public byte riskGroup
   {
      get
      {
         return this.riskGroupField;
      }
      set
      {
         this.riskGroupField = value;
      }
   }

   /// <remarks/>
   public string lossPercentage
   {
      get
      {
         return this.lossPercentageField;
      }
      set
      {
         this.lossPercentageField = value;
      }
   }

   /// <remarks/>
   public byte unsentShipments
   {
      get
      {
         return this.unsentShipmentsField;
      }
      set
      {
         this.unsentShipmentsField = value;
      }
   }

   /// <remarks/>
   public byte reputation
   {
      get
      {
         return this.reputationField;
      }
      set
      {
         this.reputationField = value;
      }
   }

   /// <remarks/>
   public byte shipsFast
   {
      get
      {
         return this.shipsFastField;
      }
      set
      {
         this.shipsFastField = value;
      }
   }

   /// <remarks/>
   public uint sellCount
   {
      get
      {
         return this.sellCountField;
      }
      set
      {
         this.sellCountField = value;
      }
   }

   /// <remarks/>
   public uint soldItems
   {
      get
      {
         return this.soldItemsField;
      }
      set
      {
         this.soldItemsField = value;
      }
   }

   /// <remarks/>
   public byte avgShippingTime
   {
      get
      {
         return this.avgShippingTimeField;
      }
      set
      {
         this.avgShippingTimeField = value;
      }
   }

   /// <remarks/>
   public bool onVacation
   {
      get
      {
         return this.onVacationField;
      }
      set
      {
         this.onVacationField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderSellerName
{

   private string companyField;

   private string firstNameField;

   private string lastNameField;

   /// <remarks/>
   public string company
   {
      get
      {
         return this.companyField;
      }
      set
      {
         this.companyField = value;
      }
   }

   /// <remarks/>
   public string firstName
   {
      get
      {
         return this.firstNameField;
      }
      set
      {
         this.firstNameField = value;
      }
   }

   /// <remarks/>
   public string lastName
   {
      get
      {
         return this.lastNameField;
      }
      set
      {
         this.lastNameField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderSellerAddress
{

   private string nameField;

   private string extraField;

   private string streetField;

   private string zipField;

   private string cityField;

   private string countryField;

   /// <remarks/>
   public string name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public string extra
   {
      get
      {
         return this.extraField;
      }
      set
      {
         this.extraField = value;
      }
   }

   /// <remarks/>
   public string street
   {
      get
      {
         return this.streetField;
      }
      set
      {
         this.streetField = value;
      }
   }

   /// <remarks/>
   public string zip
   {
      get
      {
         return this.zipField;
      }
      set
      {
         this.zipField = value;
      }
   }

   /// <remarks/>
   public string city
   {
      get
      {
         return this.cityField;
      }
      set
      {
         this.cityField = value;
      }
   }

   /// <remarks/>
   public string country
   {
      get
      {
         return this.countryField;
      }
      set
      {
         this.countryField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderBuyer
{

   private uint idUserField;

   private string usernameField;

   private string registrationDateField;

   private byte isCommercialField;

   private bool isSellerField;

   private responseOrderBuyerName nameField;

   private responseOrderBuyerAddress addressField;

   private object phoneField;

   private object emailField;

   private object vatField;

   private object legalInformationField;

   private byte riskGroupField;

   private string lossPercentageField;

   private byte unsentShipmentsField;

   private byte reputationField;

   private byte shipsFastField;

   private byte sellCountField;

   private byte soldItemsField;

   private byte avgShippingTimeField;

   private bool onVacationField;

   /// <remarks/>
   public uint idUser
   {
      get
      {
         return this.idUserField;
      }
      set
      {
         this.idUserField = value;
      }
   }

   /// <remarks/>
   public string username
   {
      get
      {
         return this.usernameField;
      }
      set
      {
         this.usernameField = value;
      }
   }

   /// <remarks/>
   public string registrationDate
   {
      get
      {
         return this.registrationDateField;
      }
      set
      {
         this.registrationDateField = value;
      }
   }

   /// <remarks/>
   public byte isCommercial
   {
      get
      {
         return this.isCommercialField;
      }
      set
      {
         this.isCommercialField = value;
      }
   }

   /// <remarks/>
   public bool isSeller
   {
      get
      {
         return this.isSellerField;
      }
      set
      {
         this.isSellerField = value;
      }
   }

   /// <remarks/>
   public responseOrderBuyerName name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public responseOrderBuyerAddress address
   {
      get
      {
         return this.addressField;
      }
      set
      {
         this.addressField = value;
      }
   }

   /// <remarks/>
   public object phone
   {
      get
      {
         return this.phoneField;
      }
      set
      {
         this.phoneField = value;
      }
   }

   /// <remarks/>
   public object email
   {
      get
      {
         return this.emailField;
      }
      set
      {
         this.emailField = value;
      }
   }

   /// <remarks/>
   public object vat
   {
      get
      {
         return this.vatField;
      }
      set
      {
         this.vatField = value;
      }
   }

   /// <remarks/>
   public object legalInformation
   {
      get
      {
         return this.legalInformationField;
      }
      set
      {
         this.legalInformationField = value;
      }
   }

   /// <remarks/>
   public byte riskGroup
   {
      get
      {
         return this.riskGroupField;
      }
      set
      {
         this.riskGroupField = value;
      }
   }

   /// <remarks/>
   public string lossPercentage
   {
      get
      {
         return this.lossPercentageField;
      }
      set
      {
         this.lossPercentageField = value;
      }
   }

   /// <remarks/>
   public byte unsentShipments
   {
      get
      {
         return this.unsentShipmentsField;
      }
      set
      {
         this.unsentShipmentsField = value;
      }
   }

   /// <remarks/>
   public byte reputation
   {
      get
      {
         return this.reputationField;
      }
      set
      {
         this.reputationField = value;
      }
   }

   /// <remarks/>
   public byte shipsFast
   {
      get
      {
         return this.shipsFastField;
      }
      set
      {
         this.shipsFastField = value;
      }
   }

   /// <remarks/>
   public byte sellCount
   {
      get
      {
         return this.sellCountField;
      }
      set
      {
         this.sellCountField = value;
      }
   }

   /// <remarks/>
   public byte soldItems
   {
      get
      {
         return this.soldItemsField;
      }
      set
      {
         this.soldItemsField = value;
      }
   }

   /// <remarks/>
   public byte avgShippingTime
   {
      get
      {
         return this.avgShippingTimeField;
      }
      set
      {
         this.avgShippingTimeField = value;
      }
   }

   /// <remarks/>
   public bool onVacation
   {
      get
      {
         return this.onVacationField;
      }
      set
      {
         this.onVacationField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderBuyerName
{

   private string firstNameField;

   /// <remarks/>
   public string firstName
   {
      get
      {
         return this.firstNameField;
      }
      set
      {
         this.firstNameField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderBuyerAddress
{

   private string nameField;

   private object extraField;

   private string streetField;

   private ushort zipField;

   private string cityField;

   private string countryField;

   /// <remarks/>
   public string name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public object extra
   {
      get
      {
         return this.extraField;
      }
      set
      {
         this.extraField = value;
      }
   }

   /// <remarks/>
   public string street
   {
      get
      {
         return this.streetField;
      }
      set
      {
         this.streetField = value;
      }
   }

   /// <remarks/>
   public ushort zip
   {
      get
      {
         return this.zipField;
      }
      set
      {
         this.zipField = value;
      }
   }

   /// <remarks/>
   public string city
   {
      get
      {
         return this.cityField;
      }
      set
      {
         this.cityField = value;
      }
   }

   /// <remarks/>
   public string country
   {
      get
      {
         return this.countryField;
      }
      set
      {
         this.countryField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderState
{

   private string stateField;

   private string dateBoughtField;

   private string datePaidField;

   private string dateSentField;

   private string dateReceivedField;

   /// <remarks/>
   public string state
   {
      get
      {
         return this.stateField;
      }
      set
      {
         this.stateField = value;
      }
   }

   /// <remarks/>
   public string dateBought
   {
      get
      {
         return this.dateBoughtField;
      }
      set
      {
         this.dateBoughtField = value;
      }
   }

   /// <remarks/>
   public string datePaid
   {
      get
      {
         return this.datePaidField;
      }
      set
      {
         this.datePaidField = value;
      }
   }

   /// <remarks/>
   public string dateSent
   {
      get
      {
         return this.dateSentField;
      }
      set
      {
         this.dateSentField = value;
      }
   }

   /// <remarks/>
   public string dateReceived
   {
      get
      {
         return this.dateReceivedField;
      }
      set
      {
         this.dateReceivedField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderShippingMethod
{

   private uint idShippingMethodField;

   private string nameField;

   private decimal priceField;

   private bool isLetterField;

   private bool isInsuredField;

   /// <remarks/>
   public uint idShippingMethod
   {
      get
      {
         return this.idShippingMethodField;
      }
      set
      {
         this.idShippingMethodField = value;
      }
   }

   /// <remarks/>
   public string name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public decimal price
   {
      get
      {
         return this.priceField;
      }
      set
      {
         this.priceField = value;
      }
   }

   /// <remarks/>
   public bool isLetter
   {
      get
      {
         return this.isLetterField;
      }
      set
      {
         this.isLetterField = value;
      }
   }

   /// <remarks/>
   public bool isInsured
   {
      get
      {
         return this.isInsuredField;
      }
      set
      {
         this.isInsuredField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderShippingAddress
{

   private string nameField;

   private object extraField;

   private string streetField;

   private ushort zipField;

   private string cityField;

   private string countryField;

   /// <remarks/>
   public string name
   {
      get
      {
         return this.nameField;
      }
      set
      {
         this.nameField = value;
      }
   }

   /// <remarks/>
   public object extra
   {
      get
      {
         return this.extraField;
      }
      set
      {
         this.extraField = value;
      }
   }

   /// <remarks/>
   public string street
   {
      get
      {
         return this.streetField;
      }
      set
      {
         this.streetField = value;
      }
   }

   /// <remarks/>
   public ushort zip
   {
      get
      {
         return this.zipField;
      }
      set
      {
         this.zipField = value;
      }
   }

   /// <remarks/>
   public string city
   {
      get
      {
         return this.cityField;
      }
      set
      {
         this.cityField = value;
      }
   }

   /// <remarks/>
   public string country
   {
      get
      {
         return this.countryField;
      }
      set
      {
         this.countryField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderEvaluation
{

   private byte evaluationGradeField;

   private byte itemDescriptionField;

   private byte packagingField;

   private string commentField;

   /// <remarks/>
   public byte evaluationGrade
   {
      get
      {
         return this.evaluationGradeField;
      }
      set
      {
         this.evaluationGradeField = value;
      }
   }

   /// <remarks/>
   public byte itemDescription
   {
      get
      {
         return this.itemDescriptionField;
      }
      set
      {
         this.itemDescriptionField = value;
      }
   }

   /// <remarks/>
   public byte packaging
   {
      get
      {
         return this.packagingField;
      }
      set
      {
         this.packagingField = value;
      }
   }

   /// <remarks/>
   public string comment
   {
      get
      {
         return this.commentField;
      }
      set
      {
         this.commentField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderArticle
{

   private uint idArticleField;

   private uint idProductField;

   private responseOrderArticleLanguage languageField;

   private string commentsField;

   private decimal priceField;

   private byte countField;

   private bool inShoppingCartField;

   private responseOrderArticleProduct productField;

   private string conditionField;

   private bool isFoilField;

   private bool isFoilFieldSpecified;

   private bool isSignedField;

   private bool isSignedFieldSpecified;

   private bool isPlaysetField;

   private bool isPlaysetFieldSpecified;

   private bool isAlteredField;

   private bool isAlteredFieldSpecified;

   /// <remarks/>
   public uint idArticle
   {
      get
      {
         return this.idArticleField;
      }
      set
      {
         this.idArticleField = value;
      }
   }

   /// <remarks/>
   public uint idProduct
   {
      get
      {
         return this.idProductField;
      }
      set
      {
         this.idProductField = value;
      }
   }

   /// <remarks/>
   public responseOrderArticleLanguage language
   {
      get
      {
         return this.languageField;
      }
      set
      {
         this.languageField = value;
      }
   }

   /// <remarks/>
   public string comments
   {
      get
      {
         return this.commentsField;
      }
      set
      {
         this.commentsField = value;
      }
   }

   /// <remarks/>
   public decimal price
   {
      get
      {
         return this.priceField;
      }
      set
      {
         this.priceField = value;
      }
   }

   /// <remarks/>
   public byte count
   {
      get
      {
         return this.countField;
      }
      set
      {
         this.countField = value;
      }
   }

   /// <remarks/>
   public bool inShoppingCart
   {
      get
      {
         return this.inShoppingCartField;
      }
      set
      {
         this.inShoppingCartField = value;
      }
   }

   /// <remarks/>
   public responseOrderArticleProduct product
   {
      get
      {
         return this.productField;
      }
      set
      {
         this.productField = value;
      }
   }

   /// <remarks/>
   public string condition
   {
      get
      {
         return this.conditionField;
      }
      set
      {
         this.conditionField = value;
      }
   }

   /// <remarks/>
   public bool isFoil
   {
      get
      {
         return this.isFoilField;
      }
      set
      {
         this.isFoilField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool isFoilSpecified
   {
      get
      {
         return this.isFoilFieldSpecified;
      }
      set
      {
         this.isFoilFieldSpecified = value;
      }
   }

   /// <remarks/>
   public bool isSigned
   {
      get
      {
         return this.isSignedField;
      }
      set
      {
         this.isSignedField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool isSignedSpecified
   {
      get
      {
         return this.isSignedFieldSpecified;
      }
      set
      {
         this.isSignedFieldSpecified = value;
      }
   }

   /// <remarks/>
   public bool isPlayset
   {
      get
      {
         return this.isPlaysetField;
      }
      set
      {
         this.isPlaysetField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool isPlaysetSpecified
   {
      get
      {
         return this.isPlaysetFieldSpecified;
      }
      set
      {
         this.isPlaysetFieldSpecified = value;
      }
   }

   /// <remarks/>
   public bool isAltered
   {
      get
      {
         return this.isAlteredField;
      }
      set
      {
         this.isAlteredField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool isAlteredSpecified
   {
      get
      {
         return this.isAlteredFieldSpecified;
      }
      set
      {
         this.isAlteredFieldSpecified = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderArticleLanguage
{

   private byte idLanguageField;

   private string languageNameField;

   /// <remarks/>
   public byte idLanguage
   {
      get
      {
         return this.idLanguageField;
      }
      set
      {
         this.idLanguageField = value;
      }
   }

   /// <remarks/>
   public string languageName
   {
      get
      {
         return this.languageNameField;
      }
      set
      {
         this.languageNameField = value;
      }
   }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseOrderArticleProduct
{

   private byte idGameField;

   private string enNameField;

   private string locNameField;

   private string imageField;

   private string expansionField;

   private string nrField;

   private ushort expIconField;

   private bool expIconFieldSpecified;

   private string rarityField;

   /// <remarks/>
   public byte idGame
   {
      get
      {
         return this.idGameField;
      }
      set
      {
         this.idGameField = value;
      }
   }

   /// <remarks/>
   public string enName
   {
      get
      {
         return this.enNameField;
      }
      set
      {
         this.enNameField = value;
      }
   }

   /// <remarks/>
   public string locName
   {
      get
      {
         return this.locNameField;
      }
      set
      {
         this.locNameField = value;
      }
   }

   /// <remarks/>
   public string image
   {
      get
      {
         return this.imageField;
      }
      set
      {
         this.imageField = value;
      }
   }

   /// <remarks/>
   public string expansion
   {
      get
      {
         return this.expansionField;
      }
      set
      {
         this.expansionField = value;
      }
   }

   /// <remarks/>
   public string nr
   {
      get
      {
         return this.nrField;
      }
      set
      {
         this.nrField = value;
      }
   }

   /// <remarks/>
   public ushort expIcon
   {
      get
      {
         return this.expIconField;
      }
      set
      {
         this.expIconField = value;
      }
   }

   /// <remarks/>
   [System.Xml.Serialization.XmlIgnoreAttribute()]
   public bool expIconSpecified
   {
      get
      {
         return this.expIconFieldSpecified;
      }
      set
      {
         this.expIconFieldSpecified = value;
      }
   }

   /// <remarks/>
   public string rarity
   {
      get
      {
         return this.rarityField;
      }
      set
      {
         this.rarityField = value;
      }
   }
}

