﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace BuyAHouse.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BuyAHouseDataEntitiesContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BuyAHouseDataEntitiesContainer object using the connection string found in the 'BuyAHouseDataEntitiesContainer' section of the application configuration file.
        /// </summary>
        public BuyAHouseDataEntitiesContainer() : base("name=BuyAHouseDataEntitiesContainer", "BuyAHouseDataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BuyAHouseDataEntitiesContainer object.
        /// </summary>
        public BuyAHouseDataEntitiesContainer(string connectionString) : base(connectionString, "BuyAHouseDataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BuyAHouseDataEntitiesContainer object.
        /// </summary>
        public BuyAHouseDataEntitiesContainer(EntityConnection connection) : base(connection, "BuyAHouseDataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Offer> Offers
        {
            get
            {
                if ((_Offers == null))
                {
                    _Offers = base.CreateObjectSet<Offer>("Offers");
                }
                return _Offers;
            }
        }
        private ObjectSet<Offer> _Offers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Offers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOffers(Offer offer)
        {
            base.AddObject("Offers", offer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BuyAHouseDataEntities", Name="Offer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Offer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Offer object.
        /// </summary>
        /// <param name="offerId">Initial value of the OfferId property.</param>
        /// <param name="buyerName">Initial value of the BuyerName property.</param>
        /// <param name="requestId">Initial value of the RequestId property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="approved">Initial value of the Approved property.</param>
        public static Offer CreateOffer(global::System.Int32 offerId, global::System.String buyerName, global::System.Guid requestId, global::System.String emailAddress, global::System.Decimal amount, global::System.Boolean approved)
        {
            Offer offer = new Offer();
            offer.OfferId = offerId;
            offer.BuyerName = buyerName;
            offer.RequestId = requestId;
            offer.EmailAddress = emailAddress;
            offer.Amount = amount;
            offer.Approved = approved;
            return offer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OfferId
        {
            get
            {
                return _OfferId;
            }
            set
            {
                if (_OfferId != value)
                {
                    OnOfferIdChanging(value);
                    ReportPropertyChanging("OfferId");
                    _OfferId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OfferId");
                    OnOfferIdChanged();
                }
            }
        }
        private global::System.Int32 _OfferId;
        partial void OnOfferIdChanging(global::System.Int32 value);
        partial void OnOfferIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BuyerName
        {
            get
            {
                return _BuyerName;
            }
            set
            {
                OnBuyerNameChanging(value);
                ReportPropertyChanging("BuyerName");
                _BuyerName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BuyerName");
                OnBuyerNameChanged();
            }
        }
        private global::System.String _BuyerName;
        partial void OnBuyerNameChanging(global::System.String value);
        partial void OnBuyerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid RequestId
        {
            get
            {
                return _RequestId;
            }
            set
            {
                OnRequestIdChanging(value);
                ReportPropertyChanging("RequestId");
                _RequestId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RequestId");
                OnRequestIdChanged();
            }
        }
        private global::System.Guid _RequestId;
        partial void OnRequestIdChanging(global::System.Guid value);
        partial void OnRequestIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Approved
        {
            get
            {
                return _Approved;
            }
            set
            {
                OnApprovedChanging(value);
                ReportPropertyChanging("Approved");
                _Approved = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Approved");
                OnApprovedChanged();
            }
        }
        private global::System.Boolean _Approved;
        partial void OnApprovedChanging(global::System.Boolean value);
        partial void OnApprovedChanged();

        #endregion
    
    }

    #endregion
    
}
