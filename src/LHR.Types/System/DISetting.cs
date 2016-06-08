﻿using LHR.Types.Constants.Entities;
using LHR.Types.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHR.Types.System
{
    /// <summary>
    /// Setting for dependency injection
    /// </summary>
    public class DISetting
    {
        /// <summary>
        /// Dependency injection scope
        /// Transient - create new object every time
        /// Scoped - create one object per HTTP request
        /// Instance - create one object per application
        /// </summary>
        public enum DIScope
        {
            Transient = 1,
            Scoped = 2,
            Instance = 3
        }
        /// <summary>
        /// Library reference type. 
        /// Static - fos statically linked libraries (typically interface libraries). 
        /// Dynamic - for 
        /// </summary>
        public enum DILibraryReferenceType
        {
            Static = 1,
            Dynamic = 2
        }
        /// <summary>
        /// Setting Identifier for future reference
        /// </summary>
        [FieldName(DISettingFieldNames.Id)]
        public Guid Id { get; set; }
        /// <summary>
        /// Assembly name of the contract
        /// </summary>
        [FieldName(DISettingFieldNames.ContractAssemblyName)]
        public string ContractAssemblyName { get; set; }
        /// <summary>
        /// Type name of the contract
        /// </summary>
        [FieldName(DISettingFieldNames.ContractTypeName)]
        public string ContractTypeName { get; set; }
        /// <summary>
        /// Assembly name of the implementation
        /// </summary>
        [FieldName(DISettingFieldNames.ImplementationAssemblyName)]
        public string ImplementationAssemblyName { get; set; }
        /// <summary>
        /// Type name of the implementation
        /// </summary>
        [FieldName(DISettingFieldNames.ImplementationTypeName)]
        public string ImplementationTypeName { get; set; }
        /// <summary>
        /// Dependency injection scope
        /// </summary>
        [FieldName(DISettingFieldNames.Scope)]
        public DIScope Scope { get; set; }
        /// <summary>
        /// Library reference type of the contract
        /// </summary>
        [FieldName(DISettingFieldNames.ContractLibraryReferenceType)]
        public DILibraryReferenceType ContractLibraryReferenceType { get; set; }
        /// <summary>
        /// Library reference type of the implementation
        /// </summary>
        [FieldName(DISettingFieldNames.ImplementationLibraryReferenceType)]
        public DILibraryReferenceType ImplementationLibraryReferenceType { get; set; }

    }
}
