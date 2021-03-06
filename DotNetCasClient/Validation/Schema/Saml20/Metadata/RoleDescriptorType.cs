﻿/*
 * Licensed to Apereo under one or more contributor license
 * agreements. See the NOTICE file distributed with this work
 * for additional information regarding copyright ownership.
 * Apereo licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a
 * copy of the License at:
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#pragma warning disable 1591

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using DotNetCasClient.Validation.Schema.XmlDsig;

namespace DotNetCasClient.Validation.Schema.Saml20.Metadata
{
    [XmlInclude(typeof(AttributeAuthorityDescriptorType))]
    [XmlInclude(typeof(PdpDescriptorType))]
    [XmlInclude(typeof(AuthnAuthorityDescriptorType))]
    [XmlInclude(typeof(SsoDescriptorType))]
    [XmlInclude(typeof(SpSsoDescriptorType))]
    [XmlInclude(typeof(IdpSsoDescriptorType))]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:metadata")]
    [XmlRoot("RoleDescriptor", Namespace="urn:oasis:names:tc:SAML:2.0:metadata", IsNullable=false)]
    public abstract class RoleDescriptorType {
        [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get;
            set;
        }

        public ExtensionsType Extensions
        {
            get;
            set;
        }

        [XmlElement("KeyDescriptor")]
        public KeyDescriptorType[] KeyDescriptor
        {
            get;
            set;
        }

        public OrganizationType Organization
        {
            get;
            set;
        }

        [XmlElement("ContactPerson")]
        public ContactType[] ContactPerson
        {
            get;
            set;
        }

        [XmlAttribute("ID", DataType="ID")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute("validUntil")]
        public DateTime ValidUntil
        {
            get;
            set;
        }

        [XmlIgnore]
        public bool ValidUntilSpecified
        {
            get;
            set;
        }

        [XmlAttribute("cacheDuration",DataType="duration")]
        public string CacheDuration
        {
            get;
            set;
        }

        [XmlAttribute("protocolSupportEnumeration", DataType="anyURI")]
        public string[] ProtocolSupportEnumeration
        {
            get;
            set;
        }

        [XmlAttribute("errorURL", DataType="anyURI")]
        public string ErrorUrl
        {
            get;
            set;
        }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttr
        {
            get;
            set;
        }
    }
}

#pragma warning restore 1591