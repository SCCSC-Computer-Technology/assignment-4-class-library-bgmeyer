﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BroecklynneMeyer_CPT_206_Assignment_3
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="States")]
	public partial class StatesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    #endregion
		
		public StatesDataContext() : 
				base(global::BroecklynneMeyer_CPT_206_Assignment_3.Properties.Settings.Default.States1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StatesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StatesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.States")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StateID;
		
		private string _Population;
		
		private string _Flower;
		
		private string _Bird;
		
		private string _Capitol;
		
		private string _FlagDescription;
		
		private string _Color;
		
		private string _MedianIncome;
		
		private string _ComputerRelatedJobs;
		
		private string _LargestCity;
		
		private string _SecondLargestCity;
		
		private string _ThirdLargestCity;
		
		private System.Data.Linq.Binary _SSMA_TimeStamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStateIDChanging(string value);
    partial void OnStateIDChanged();
    partial void OnPopulationChanging(string value);
    partial void OnPopulationChanged();
    partial void OnFlowerChanging(string value);
    partial void OnFlowerChanged();
    partial void OnBirdChanging(string value);
    partial void OnBirdChanged();
    partial void OnCapitolChanging(string value);
    partial void OnCapitolChanged();
    partial void OnFlagDescriptionChanging(string value);
    partial void OnFlagDescriptionChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnMedianIncomeChanging(string value);
    partial void OnMedianIncomeChanged();
    partial void OnComputerRelatedJobsChanging(string value);
    partial void OnComputerRelatedJobsChanged();
    partial void OnLargestCityChanging(string value);
    partial void OnLargestCityChanged();
    partial void OnSecondLargestCityChanging(string value);
    partial void OnSecondLargestCityChanged();
    partial void OnThirdLargestCityChanging(string value);
    partial void OnThirdLargestCityChanged();
    partial void OnSSMA_TimeStampChanging(System.Data.Linq.Binary value);
    partial void OnSSMA_TimeStampChanged();
    #endregion
		
		public State()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this.OnStateIDChanging(value);
					this.SendPropertyChanging();
					this._StateID = value;
					this.SendPropertyChanged("StateID");
					this.OnStateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flower", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Flower
		{
			get
			{
				return this._Flower;
			}
			set
			{
				if ((this._Flower != value))
				{
					this.OnFlowerChanging(value);
					this.SendPropertyChanging();
					this._Flower = value;
					this.SendPropertyChanged("Flower");
					this.OnFlowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bird", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Bird
		{
			get
			{
				return this._Bird;
			}
			set
			{
				if ((this._Bird != value))
				{
					this.OnBirdChanging(value);
					this.SendPropertyChanging();
					this._Bird = value;
					this.SendPropertyChanged("Bird");
					this.OnBirdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capitol", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Capitol
		{
			get
			{
				return this._Capitol;
			}
			set
			{
				if ((this._Capitol != value))
				{
					this.OnCapitolChanging(value);
					this.SendPropertyChanging();
					this._Capitol = value;
					this.SendPropertyChanged("Capitol");
					this.OnCapitolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlagDescription", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string FlagDescription
		{
			get
			{
				return this._FlagDescription;
			}
			set
			{
				if ((this._FlagDescription != value))
				{
					this.OnFlagDescriptionChanging(value);
					this.SendPropertyChanging();
					this._FlagDescription = value;
					this.SendPropertyChanged("FlagDescription");
					this.OnFlagDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedianIncome", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string MedianIncome
		{
			get
			{
				return this._MedianIncome;
			}
			set
			{
				if ((this._MedianIncome != value))
				{
					this.OnMedianIncomeChanging(value);
					this.SendPropertyChanging();
					this._MedianIncome = value;
					this.SendPropertyChanged("MedianIncome");
					this.OnMedianIncomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComputerRelatedJobs", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string ComputerRelatedJobs
		{
			get
			{
				return this._ComputerRelatedJobs;
			}
			set
			{
				if ((this._ComputerRelatedJobs != value))
				{
					this.OnComputerRelatedJobsChanging(value);
					this.SendPropertyChanging();
					this._ComputerRelatedJobs = value;
					this.SendPropertyChanged("ComputerRelatedJobs");
					this.OnComputerRelatedJobsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LargestCity", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string LargestCity
		{
			get
			{
				return this._LargestCity;
			}
			set
			{
				if ((this._LargestCity != value))
				{
					this.OnLargestCityChanging(value);
					this.SendPropertyChanging();
					this._LargestCity = value;
					this.SendPropertyChanged("LargestCity");
					this.OnLargestCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecondLargestCity", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string SecondLargestCity
		{
			get
			{
				return this._SecondLargestCity;
			}
			set
			{
				if ((this._SecondLargestCity != value))
				{
					this.OnSecondLargestCityChanging(value);
					this.SendPropertyChanging();
					this._SecondLargestCity = value;
					this.SendPropertyChanged("SecondLargestCity");
					this.OnSecondLargestCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThirdLargestCity", DbType="NVarChar(255)", UpdateCheck=UpdateCheck.Never)]
		public string ThirdLargestCity
		{
			get
			{
				return this._ThirdLargestCity;
			}
			set
			{
				if ((this._ThirdLargestCity != value))
				{
					this.OnThirdLargestCityChanging(value);
					this.SendPropertyChanging();
					this._ThirdLargestCity = value;
					this.SendPropertyChanged("ThirdLargestCity");
					this.OnThirdLargestCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSMA_TimeStamp", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary SSMA_TimeStamp
		{
			get
			{
				return this._SSMA_TimeStamp;
			}
			set
			{
				if ((this._SSMA_TimeStamp != value))
				{
					this.OnSSMA_TimeStampChanging(value);
					this.SendPropertyChanging();
					this._SSMA_TimeStamp = value;
					this.SendPropertyChanged("SSMA_TimeStamp");
					this.OnSSMA_TimeStampChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591