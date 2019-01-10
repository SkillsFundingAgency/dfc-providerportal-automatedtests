
using System;
using System.Collections.Generic;

public class Providers
{
    public string UnitedKingdomProviderReferenceNumber { get; set; }
    public string ProviderName { get; set; }
    public string ProviderStatus { get; set; }
    public Providercontact[] ProviderContact { get; set; }
    public DateTime ProviderVerificationDate { get; set; }
    public bool ProviderVerificationDateSpecified { get; set; }
    public bool ExpiryDateSpecified { get; set; }
    public object ProviderAssociations { get; set; }
    public Provideralias[] ProviderAliases { get; set; }
    public Verificationdetail[] VerificationDetails { get; set; }
}

public class Providercontact
{
    public string ContactType { get; set; }
    public Contactaddress ContactAddress { get; set; }
    public ContactPersonalDetails ContactPersonalDetails { get; set; }
    public string ContactRole { get; set; }
    public string ContactTelephone1 { get; set; }
    public object ContactTelephone2 { get; set; }
    public string ContactFax { get; set; }
    public string ContactWebsiteAddress { get; set; }
    public string ContactEmail { get; set; }
    public DateTime LastUpdated { get; set; }
}

public class Contactaddress
{
    public SAON SAON { get; set; }
    public PAON PAON { get; set; }
    public string StreetDescription { get; set; }
    public object UniqueStreetReferenceNumber { get; set; }
    public string Locality { get; set; }
    public string[] Items { get; set; }
    public int[] ItemsElementName { get; set; }
    public object PostTown { get; set; }
    public string PostCode { get; set; }
    public object UniquePropertyReferenceNumber { get; set; }
}

public class SAON
{
    public object Description { get; set; }
}

public class PAON
{
    public string Description { get; set; }
}

public class ContactPersonalDetails
{
    public string[] PersonNameTitle { get; set; }
    public string[] PersonGivenName { get; set; }
    public string PersonFamilyName { get; set; }
    public object PersonNameSuffix { get; set; }
    public object PersonRequestedName { get; set; }
}

public class Provideralias
{
    public object ProviderAlias { get; set; }
    public object LastUpdated { get; set; }
}

public class Verificationdetail
{
    public string VerificationAuthority { get; set; }
    public string VerificationID { get; set; }
}
