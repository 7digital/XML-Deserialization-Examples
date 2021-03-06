using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XsdToObjectsExtracting.Generated
{
	public class NewReleaseMessage
	{
		public MessageHeader MessageHeader { get; set; }
		public string UpdateIndicator { get; set; }
		public CatalogTransfer CatalogTransfer { get; set; }
		public WorkList WorkList { get; set; }
		public CueSheetList CueSheetList { get; set; }
		public ResourceList ResourceList { get; set; }
		public CollectionList CollectionList { get; set; }
		public ReleaseList ReleaseList { get; set; }
		public DealList DealList { get; set; }

		public NewReleaseMessage(XElement element)
		{
			MessageHeader = element.Elements().Where(e => e.Name == "MessageHeader").Select(e => new MessageHeader(e)).SingleOrDefault();
			UpdateIndicator = element.Elements().Where(e => e.Name == "UpdateIndicator").Select(e => e.Value).SingleOrDefault();
			CatalogTransfer = element.Elements().Where(e => e.Name == "CatalogTransfer").Select(e => new CatalogTransfer(e)).SingleOrDefault();
			WorkList = element.Elements().Where(e => e.Name == "WorkList").Select(e => new WorkList(e)).SingleOrDefault();
			CueSheetList = element.Elements().Where(e => e.Name == "CueSheetList").Select(e => new CueSheetList(e)).SingleOrDefault();
			ResourceList = element.Elements().Where(e => e.Name == "ResourceList").Select(e => new ResourceList(e)).SingleOrDefault();
			CollectionList = element.Elements().Where(e => e.Name == "CollectionList").Select(e => new CollectionList(e)).SingleOrDefault();
			ReleaseList = element.Elements().Where(e => e.Name == "ReleaseList").Select(e => new ReleaseList(e)).SingleOrDefault();
			DealList = element.Elements().Where(e => e.Name == "DealList").Select(e => new DealList(e)).SingleOrDefault();
		}

		public NewReleaseMessage()
		{ }
	}

	public class CatalogListMessage
	{
		public MessageHeader MessageHeader { get; set; }
		public string PublicationDate { get; set; }
		public IList<CatalogItem> CatalogItems { get; set; }

		public CatalogListMessage(XElement element)
		{
			MessageHeader = element.Elements().Where(e => e.Name == "MessageHeader").Select(e => new MessageHeader(e)).SingleOrDefault();
			PublicationDate = element.Elements().Where(e => e.Name == "PublicationDate").Select(e => e.Value).SingleOrDefault();
			CatalogItems = element.Elements().Where(e => e.Name == "CatalogItem").Select(e => new CatalogItem(e)).ToList();
		}

		public CatalogListMessage()
		{ }
	}

	public class CatalogItem
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<ReleaseId> ReleaseIds { get; set; }
		public Title Title { get; set; }
		public string DisplayArtistName { get; set; }
		public IList<string> ContributorNames { get; set; }
		public ReferenceTitle DisplayTitle { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public string ReleaseDate { get; set; }

		public CatalogItem(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			Title = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).SingleOrDefault();
			DisplayArtistName = element.Elements().Where(e => e.Name == "DisplayArtistName").Select(e => e.Value).SingleOrDefault();
			ContributorNames = element.Elements().Where(e => e.Name == "ContributorName").Select(e => e.Value).ToList();
			DisplayTitle = element.Elements().Where(e => e.Name == "DisplayTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			ReleaseDate = element.Elements().Where(e => e.Name == "ReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public CatalogItem()
		{ }
	}

	public class CatalogReleaseReferenceList
	{
		public IList<string> CatalogReleaseReferences { get; set; }

		public CatalogReleaseReferenceList(XElement element)
		{
			CatalogReleaseReferences = element.Elements().Where(e => e.Name == "CatalogReleaseReference").Select(e => e.Value).ToList();
		}

		public CatalogReleaseReferenceList()
		{ }
	}

	public class CatalogTransfer
	{
		public string CatalogTransferCompleted { get; set; }
		public string EffectiveTransferDate { get; set; }
		public CatalogReleaseReferenceList CatalogReleaseReferenceList { get; set; }
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public PartyDescriptor TransferringFrom { get; set; }
		public PartyDescriptor TransferringTo { get; set; }

		public CatalogTransfer(XElement element)
		{
			CatalogTransferCompleted = element.Elements().Where(e => e.Name == "CatalogTransferCompleted").Select(e => e.Value).SingleOrDefault();
			EffectiveTransferDate = element.Elements().Where(e => e.Name == "EffectiveTransferDate").Select(e => e.Value).SingleOrDefault();
			CatalogReleaseReferenceList = element.Elements().Where(e => e.Name == "CatalogReleaseReferenceList").Select(e => new CatalogReleaseReferenceList(e)).SingleOrDefault();
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			TransferringFrom = element.Elements().Where(e => e.Name == "TransferringFrom").Select(e => new PartyDescriptor(e)).SingleOrDefault();
			TransferringTo = element.Elements().Where(e => e.Name == "TransferringTo").Select(e => new PartyDescriptor(e)).SingleOrDefault();
		}

		public CatalogTransfer()
		{ }
	}

	public class Collection
	{
		public IList<CollectionId> CollectionIds { get; set; }
		public IList<string> CollectionTypes { get; set; }
		public string CollectionReference { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> Contributors { get; set; }
		public IList<Character> Characters { get; set; }
		public CollectionCollectionReferenceList CollectionCollectionReferenceList { get; set; }
		public string IsComplete { get; set; }
		public string Duration { get; set; }
		public string DurationOfMusicalContent { get; set; }
		public string CreationDate { get; set; }
		public string OriginalReleaseDate { get; set; }
		public string OriginalLanguage { get; set; }
		public IList<CollectionDetailsByTerritory> CollectionDetailsByTerritorys { get; set; }
		public CollectionResourceReferenceList CollectionResourceReferenceList { get; set; }
		public CollectionWorkReferenceList CollectionWorkReferenceList { get; set; }
		public string RepresentativeImageReference { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }

		public Collection(XElement element)
		{
			CollectionIds = element.Elements().Where(e => e.Name == "CollectionId").Select(e => new CollectionId(e)).ToList();
			CollectionTypes = element.Elements().Where(e => e.Name == "CollectionType").Select(e => e.Value).ToList();
			CollectionReference = element.Elements().Where(e => e.Name == "CollectionReference").Select(e => e.Value).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			Contributors = element.Elements().Where(e => e.Name == "Contributor").Select(e => new ResourceContributor(e)).ToList();
			Characters = element.Elements().Where(e => e.Name == "Character").Select(e => new Character(e)).ToList();
			CollectionCollectionReferenceList = element.Elements().Where(e => e.Name == "CollectionCollectionReferenceList").Select(e => new CollectionCollectionReferenceList(e)).SingleOrDefault();
			IsComplete = element.Elements().Where(e => e.Name == "IsComplete").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			DurationOfMusicalContent = element.Elements().Where(e => e.Name == "DurationOfMusicalContent").Select(e => e.Value).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			OriginalReleaseDate = element.Elements().Where(e => e.Name == "OriginalReleaseDate").Select(e => e.Value).SingleOrDefault();
			OriginalLanguage = element.Elements().Where(e => e.Name == "OriginalLanguage").Select(e => e.Value).SingleOrDefault();
			CollectionDetailsByTerritorys = element.Elements().Where(e => e.Name == "CollectionDetailsByTerritory").Select(e => new CollectionDetailsByTerritory(e)).ToList();
			CollectionResourceReferenceList = element.Elements().Where(e => e.Name == "CollectionResourceReferenceList").Select(e => new CollectionResourceReferenceList(e)).SingleOrDefault();
			CollectionWorkReferenceList = element.Elements().Where(e => e.Name == "CollectionWorkReferenceList").Select(e => new CollectionWorkReferenceList(e)).SingleOrDefault();
			RepresentativeImageReference = element.Elements().Where(e => e.Name == "RepresentativeImageReference").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
		}

		public Collection()
		{ }
	}

	public class CollectionDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> Contributors { get; set; }
		public string IsComplete { get; set; }
		public IList<Character> Characters { get; set; }

		public CollectionDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			Contributors = element.Elements().Where(e => e.Name == "Contributor").Select(e => new ResourceContributor(e)).ToList();
			IsComplete = element.Elements().Where(e => e.Name == "IsComplete").Select(e => e.Value).SingleOrDefault();
			Characters = element.Elements().Where(e => e.Name == "Character").Select(e => new Character(e)).ToList();
		}

		public CollectionDetailsByTerritory()
		{ }
	}

	public class CollectionList
	{
		public IList<Collection> Collections { get; set; }

		public CollectionList(XElement element)
		{
			Collections = element.Elements().Where(e => e.Name == "Collection").Select(e => new Collection(e)).ToList();
		}

		public CollectionList()
		{ }
	}

	public class CollectionResourceReference
	{
		public string CollectionResourceReferenceProp { get; set; }
		public string Duration { get; set; }

		public CollectionResourceReference(XElement element)
		{
			CollectionResourceReferenceProp = element.Elements().Where(e => e.Name == "CollectionResourceReference").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
		}

		public CollectionResourceReference()
		{ }
	}

	public class CollectionResourceReferenceList
	{
		public IList<CollectionResourceReference> CollectionResourceReferences { get; set; }

		public CollectionResourceReferenceList(XElement element)
		{
			CollectionResourceReferences = element.Elements().Where(e => e.Name == "CollectionResourceReference").Select(e => new CollectionResourceReference(e)).ToList();
		}

		public CollectionResourceReferenceList()
		{ }
	}

	public class CollectionWorkReference
	{
		public string CollectionWorkReferenceProp { get; set; }
		public string Duration { get; set; }

		public CollectionWorkReference(XElement element)
		{
			CollectionWorkReferenceProp = element.Elements().Where(e => e.Name == "CollectionWorkReference").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
		}

		public CollectionWorkReference()
		{ }
	}

	public class CollectionWorkReferenceList
	{
		public IList<CollectionWorkReference> CollectionWorkReferences { get; set; }

		public CollectionWorkReferenceList(XElement element)
		{
			CollectionWorkReferences = element.Elements().Where(e => e.Name == "CollectionWorkReference").Select(e => new CollectionWorkReference(e)).ToList();
		}

		public CollectionWorkReferenceList()
		{ }
	}

	public class Condition
	{
		public string Value { get; set; }
		public string Unit { get; set; }
		public string RelationalRelator { get; set; }

		public Condition(XElement element)
		{
			Value = element.Elements().Where(e => e.Name == "Value").Select(e => e.Value).SingleOrDefault();
			Unit = element.Elements().Where(e => e.Name == "Unit").Select(e => e.Value).SingleOrDefault();
			RelationalRelator = element.Elements().Where(e => e.Name == "RelationalRelator").Select(e => e.Value).SingleOrDefault();
		}

		public Condition()
		{ }
	}

	public class Cue
	{
		public string CueUseType { get; set; }
		public string CueThemeType { get; set; }
		public string CueVocalType { get; set; }
		public string IsDance { get; set; }
		public string CueVisualPerceptionType { get; set; }
		public string CueOrigin { get; set; }
		public IList<CueCreationReference> CueCreationReferences { get; set; }
		public string ReferencedCreationType { get; set; }
		public CreationId ReferencedCreationId { get; set; }
		public IList<Title> ReferencedCreationTitles { get; set; }
		public IList<ResourceContributor> ReferencedCreationContributors { get; set; }
		public IList<Character> ReferencedCreationCharacters { get; set; }
		public string HasMusicalContent { get; set; }
		public string StartTime { get; set; }
		public string Duration { get; set; }
		public string EndTime { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }

		public Cue(XElement element)
		{
			CueUseType = element.Elements().Where(e => e.Name == "CueUseType").Select(e => e.Value).SingleOrDefault();
			CueThemeType = element.Elements().Where(e => e.Name == "CueThemeType").Select(e => e.Value).SingleOrDefault();
			CueVocalType = element.Elements().Where(e => e.Name == "CueVocalType").Select(e => e.Value).SingleOrDefault();
			IsDance = element.Elements().Where(e => e.Name == "IsDance").Select(e => e.Value).SingleOrDefault();
			CueVisualPerceptionType = element.Elements().Where(e => e.Name == "CueVisualPerceptionType").Select(e => e.Value).SingleOrDefault();
			CueOrigin = element.Elements().Where(e => e.Name == "CueOrigin").Select(e => e.Value).SingleOrDefault();
			CueCreationReferences = element.Elements().Where(e => e.Name == "CueCreationReference").Select(e => new CueCreationReference(e)).ToList();
			ReferencedCreationType = element.Elements().Where(e => e.Name == "ReferencedCreationType").Select(e => e.Value).SingleOrDefault();
			ReferencedCreationId = element.Elements().Where(e => e.Name == "ReferencedCreationId").Select(e => new CreationId(e)).SingleOrDefault();
			ReferencedCreationTitles = element.Elements().Where(e => e.Name == "ReferencedCreationTitle").Select(e => new Title(e)).ToList();
			ReferencedCreationContributors = element.Elements().Where(e => e.Name == "ReferencedCreationContributor").Select(e => new ResourceContributor(e)).ToList();
			ReferencedCreationCharacters = element.Elements().Where(e => e.Name == "ReferencedCreationCharacter").Select(e => new Character(e)).ToList();
			HasMusicalContent = element.Elements().Where(e => e.Name == "HasMusicalContent").Select(e => e.Value).SingleOrDefault();
			StartTime = element.Elements().Where(e => e.Name == "StartTime").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			EndTime = element.Elements().Where(e => e.Name == "EndTime").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
		}

		public Cue()
		{ }
	}

	public class CueSheet
	{
		public IList<string> CueSheetIds { get; set; }
		public string CueSheetReference { get; set; }
		public string CueSheetType { get; set; }
		public IList<Cue> Cues { get; set; }

		public CueSheet(XElement element)
		{
			CueSheetIds = element.Elements().Where(e => e.Name == "CueSheetId").Select(e => e.Value).ToList();
			CueSheetReference = element.Elements().Where(e => e.Name == "CueSheetReference").Select(e => e.Value).SingleOrDefault();
			CueSheetType = element.Elements().Where(e => e.Name == "CueSheetType").Select(e => e.Value).SingleOrDefault();
			Cues = element.Elements().Where(e => e.Name == "Cue").Select(e => new Cue(e)).ToList();
		}

		public CueSheet()
		{ }
	}

	public class CueSheetList
	{
		public IList<CueSheet> CueSheets { get; set; }

		public CueSheetList(XElement element)
		{
			CueSheets = element.Elements().Where(e => e.Name == "CueSheet").Select(e => new CueSheet(e)).ToList();
		}

		public CueSheetList()
		{ }
	}

	public class Deal
	{
		public IList<string> DealReferences { get; set; }
		public DealTerms DealTerms { get; set; }
		public ResourceUsage ResourceUsage { get; set; }
		public DealTechnicalResourceDetailsReferenceList DealTechnicalResourceDetailsReferenceList { get; set; }
		public IList<WebPage> DistributionChannelPages { get; set; }

		public Deal(XElement element)
		{
			DealReferences = element.Elements().Where(e => e.Name == "DealReference").Select(e => e.Value).ToList();
			DealTerms = element.Elements().Where(e => e.Name == "DealTerms").Select(e => new DealTerms(e)).SingleOrDefault();
			ResourceUsage = element.Elements().Where(e => e.Name == "ResourceUsage").Select(e => new ResourceUsage(e)).SingleOrDefault();
			DealTechnicalResourceDetailsReferenceList = element.Elements().Where(e => e.Name == "DealTechnicalResourceDetailsReferenceList").Select(e => new DealTechnicalResourceDetailsReferenceList(e)).SingleOrDefault();
			DistributionChannelPages = element.Elements().Where(e => e.Name == "DistributionChannelPage").Select(e => new WebPage(e)).ToList();
		}

		public Deal()
		{ }
	}

	public class DealList
	{
		public IList<ReleaseDeal> ReleaseDeals { get; set; }

		public DealList(XElement element)
		{
			ReleaseDeals = element.Elements().Where(e => e.Name == "ReleaseDeal").Select(e => new ReleaseDeal(e)).ToList();
		}

		public DealList()
		{ }
	}

	public class DealTechnicalResourceDetailsReferenceList
	{
		public IList<string> DealTechnicalResourceDetailsReferences { get; set; }

		public DealTechnicalResourceDetailsReferenceList(XElement element)
		{
			DealTechnicalResourceDetailsReferences = element.Elements().Where(e => e.Name == "DealTechnicalResourceDetailsReference").Select(e => e.Value).ToList();
		}

		public DealTechnicalResourceDetailsReferenceList()
		{ }
	}

	public class DealTerms
	{
		public IList<string> CommercialModelTypes { get; set; }
		public IList<Usage> Usages { get; set; }
		public string AllDealsCancelled { get; set; }
		public string TakeDown { get; set; }
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<DSP> DistributionChannels { get; set; }
		public IList<DSP> ExcludedDistributionChannels { get; set; }
		public IList<PriceInformation> PriceInformations { get; set; }
		public string IsPromotional { get; set; }
		public string PromotionalCode { get; set; }
		public IList<Period> ValidityPeriods { get; set; }
		public string ConsumerRentalPeriod { get; set; }
		public string PreOrderReleaseDate { get; set; }
		public string PreOrderPreviewDate { get; set; }
		public string IsExclusive { get; set; }
		public IList<RelatedReleaseOfferSet> RelatedReleaseOfferSets { get; set; }
		public PhysicalReturns PhysicalReturns { get; set; }
		public string NumberOfProductsPerCarton { get; set; }
		public IList<RightsClaimPolicy> RightsClaimPolicys { get; set; }
		public IList<WebPolicy> WebPolicys { get; set; }

		public DealTerms(XElement element)
		{
			CommercialModelTypes = element.Elements().Where(e => e.Name == "CommercialModelType").Select(e => e.Value).ToList();
			Usages = element.Elements().Where(e => e.Name == "Usage").Select(e => new Usage(e)).ToList();
			AllDealsCancelled = element.Elements().Where(e => e.Name == "AllDealsCancelled").Select(e => e.Value).SingleOrDefault();
			TakeDown = element.Elements().Where(e => e.Name == "TakeDown").Select(e => e.Value).SingleOrDefault();
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			DistributionChannels = element.Elements().Where(e => e.Name == "DistributionChannel").Select(e => new DSP(e)).ToList();
			ExcludedDistributionChannels = element.Elements().Where(e => e.Name == "ExcludedDistributionChannel").Select(e => new DSP(e)).ToList();
			PriceInformations = element.Elements().Where(e => e.Name == "PriceInformation").Select(e => new PriceInformation(e)).ToList();
			IsPromotional = element.Elements().Where(e => e.Name == "IsPromotional").Select(e => e.Value).SingleOrDefault();
			PromotionalCode = element.Elements().Where(e => e.Name == "PromotionalCode").Select(e => e.Value).SingleOrDefault();
			ValidityPeriods = element.Elements().Where(e => e.Name == "ValidityPeriod").Select(e => new Period(e)).ToList();
			ConsumerRentalPeriod = element.Elements().Where(e => e.Name == "ConsumerRentalPeriod").Select(e => e.Value).SingleOrDefault();
			PreOrderReleaseDate = element.Elements().Where(e => e.Name == "PreOrderReleaseDate").Select(e => e.Value).SingleOrDefault();
			PreOrderPreviewDate = element.Elements().Where(e => e.Name == "PreOrderPreviewDate").Select(e => e.Value).SingleOrDefault();
			IsExclusive = element.Elements().Where(e => e.Name == "IsExclusive").Select(e => e.Value).SingleOrDefault();
			RelatedReleaseOfferSets = element.Elements().Where(e => e.Name == "RelatedReleaseOfferSet").Select(e => new RelatedReleaseOfferSet(e)).ToList();
			PhysicalReturns = element.Elements().Where(e => e.Name == "PhysicalReturns").Select(e => new PhysicalReturns(e)).SingleOrDefault();
			NumberOfProductsPerCarton = element.Elements().Where(e => e.Name == "NumberOfProductsPerCarton").Select(e => e.Value).SingleOrDefault();
			RightsClaimPolicys = element.Elements().Where(e => e.Name == "RightsClaimPolicy").Select(e => new RightsClaimPolicy(e)).ToList();
			WebPolicys = element.Elements().Where(e => e.Name == "WebPolicy").Select(e => new WebPolicy(e)).ToList();
		}

		public DealTerms()
		{ }
	}

	public class Image
	{
		public string ImageType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<ImageId> ImageIds { get; set; }
		public string ResourceReference { get; set; }
		public IList<Title> Titles { get; set; }
		public string CreationDate { get; set; }
		public IList<ImageDetailsByTerritory> ImageDetailsByTerritorys { get; set; }

		public Image(XElement element)
		{
			ImageType = element.Elements().Where(e => e.Name == "ImageType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			ImageIds = element.Elements().Where(e => e.Name == "ImageId").Select(e => new ImageId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			ImageDetailsByTerritorys = element.Elements().Where(e => e.Name == "ImageDetailsByTerritory").Select(e => new ImageDetailsByTerritory(e)).ToList();
		}

		public Image()
		{ }
	}

	public class ImageDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string Description { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<TechnicalImageDetails> TechnicalImageDetails { get; set; }

		public ImageDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			Description = element.Elements().Where(e => e.Name == "Description").Select(e => e.Value).SingleOrDefault();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			TechnicalImageDetails = element.Elements().Where(e => e.Name == "TechnicalImageDetails").Select(e => new TechnicalImageDetails(e)).ToList();
		}

		public ImageDetailsByTerritory()
		{ }
	}

	public class MIDI
	{
		public string MidiType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<MidiId> MidiIds { get; set; }
		public IList<MusicalWorkId> IndirectMidiIds { get; set; }
		public string ResourceReference { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public string InstrumentationDescription { get; set; }
		public string IsMedley { get; set; }
		public string IsPotpourri { get; set; }
		public string IsInstrumental { get; set; }
		public string IsBackground { get; set; }
		public string IsHiddenResource { get; set; }
		public string IsBonusResource { get; set; }
		public string IsComputerGenerated { get; set; }
		public string NoSilenceBefore { get; set; }
		public string NoSilenceAfter { get; set; }
		public string PerformerInformationRequired { get; set; }
		public string LanguageOfPerformance { get; set; }
		public string Duration { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public string CreationDate { get; set; }
		public string MasteredDate { get; set; }
		public IList<MidiDetailsByTerritory> MidiDetailsByTerritorys { get; set; }

		public MIDI(XElement element)
		{
			MidiType = element.Elements().Where(e => e.Name == "MidiType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			MidiIds = element.Elements().Where(e => e.Name == "MidiId").Select(e => new MidiId(e)).ToList();
			IndirectMidiIds = element.Elements().Where(e => e.Name == "IndirectMidiId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			InstrumentationDescription = element.Elements().Where(e => e.Name == "InstrumentationDescription").Select(e => e.Value).SingleOrDefault();
			IsMedley = element.Elements().Where(e => e.Name == "IsMedley").Select(e => e.Value).SingleOrDefault();
			IsPotpourri = element.Elements().Where(e => e.Name == "IsPotpourri").Select(e => e.Value).SingleOrDefault();
			IsInstrumental = element.Elements().Where(e => e.Name == "IsInstrumental").Select(e => e.Value).SingleOrDefault();
			IsBackground = element.Elements().Where(e => e.Name == "IsBackground").Select(e => e.Value).SingleOrDefault();
			IsHiddenResource = element.Elements().Where(e => e.Name == "IsHiddenResource").Select(e => e.Value).SingleOrDefault();
			IsBonusResource = element.Elements().Where(e => e.Name == "IsBonusResource").Select(e => e.Value).SingleOrDefault();
			IsComputerGenerated = element.Elements().Where(e => e.Name == "IsComputerGenerated").Select(e => e.Value).SingleOrDefault();
			NoSilenceBefore = element.Elements().Where(e => e.Name == "NoSilenceBefore").Select(e => e.Value).SingleOrDefault();
			NoSilenceAfter = element.Elements().Where(e => e.Name == "NoSilenceAfter").Select(e => e.Value).SingleOrDefault();
			PerformerInformationRequired = element.Elements().Where(e => e.Name == "PerformerInformationRequired").Select(e => e.Value).SingleOrDefault();
			LanguageOfPerformance = element.Elements().Where(e => e.Name == "LanguageOfPerformance").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			MasteredDate = element.Elements().Where(e => e.Name == "MasteredDate").Select(e => e.Value).SingleOrDefault();
			MidiDetailsByTerritorys = element.Elements().Where(e => e.Name == "MidiDetailsByTerritory").Select(e => new MidiDetailsByTerritory(e)).ToList();
		}

		public MIDI()
		{ }
	}

	public class MidiDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string SequenceNumber { get; set; }
		public IList<HostSoundCarrier> HostSoundCarriers { get; set; }
		public string MarketingComment { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<TechnicalMidiDetails> TechnicalMidiDetails { get; set; }

		public MidiDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			HostSoundCarriers = element.Elements().Where(e => e.Name == "HostSoundCarrier").Select(e => new HostSoundCarrier(e)).ToList();
			MarketingComment = element.Elements().Where(e => e.Name == "MarketingComment").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			TechnicalMidiDetails = element.Elements().Where(e => e.Name == "TechnicalMidiDetails").Select(e => new TechnicalMidiDetails(e)).ToList();
		}

		public MidiDetailsByTerritory()
		{ }
	}

	public class PhysicalReturns
	{
		public string PhysicalReturnsAllowed { get; set; }
		public string LatestDateForPhysicalReturns { get; set; }

		public PhysicalReturns(XElement element)
		{
			PhysicalReturnsAllowed = element.Elements().Where(e => e.Name == "PhysicalReturnsAllowed").Select(e => e.Value).SingleOrDefault();
			LatestDateForPhysicalReturns = element.Elements().Where(e => e.Name == "LatestDateForPhysicalReturns").Select(e => e.Value).SingleOrDefault();
		}

		public PhysicalReturns()
		{ }
	}

	public class PreviewDetails
	{
		public string PartType { get; set; }
		public string TopLeftCorner { get; set; }
		public string BottomRightCorner { get; set; }
		public string ExpressionType { get; set; }

		public PreviewDetails(XElement element)
		{
			PartType = element.Elements().Where(e => e.Name == "PartType").Select(e => e.Value).SingleOrDefault();
			TopLeftCorner = element.Elements().Where(e => e.Name == "TopLeftCorner").Select(e => e.Value).SingleOrDefault();
			BottomRightCorner = element.Elements().Where(e => e.Name == "BottomRightCorner").Select(e => e.Value).SingleOrDefault();
			ExpressionType = element.Elements().Where(e => e.Name == "ExpressionType").Select(e => e.Value).SingleOrDefault();
		}

		public PreviewDetails()
		{ }
	}

	public class RelatedReleaseOfferSet
	{
		public IList<ReleaseId> ReleaseIds { get; set; }
		public string ReleaseDescription { get; set; }
		public IList<Deal> Deals { get; set; }

		public RelatedReleaseOfferSet(XElement element)
		{
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			ReleaseDescription = element.Elements().Where(e => e.Name == "ReleaseDescription").Select(e => e.Value).SingleOrDefault();
			Deals = element.Elements().Where(e => e.Name == "Deal").Select(e => new Deal(e)).ToList();
		}

		public RelatedReleaseOfferSet()
		{ }
	}

	public class Release
	{
		public IList<ReleaseId> ReleaseIds { get; set; }
		public IList<string> ReleaseReferences { get; set; }
		public IList<ExternalResourceLink> ExternalResourceLinks { get; set; }
		public IList<SalesReportingProxyReleaseId> SalesReportingProxyReleaseIds { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public ReleaseResourceReferenceList ReleaseResourceReferenceList { get; set; }
		public string ResourceOmissionReason { get; set; }
		public ReleaseCollectionReferenceList ReleaseCollectionReferenceList { get; set; }
		public IList<string> ReleaseTypes { get; set; }
		public IList<ReleaseDetailsByTerritory> ReleaseDetailsByTerritorys { get; set; }
		public string Duration { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public IList<WebPage> ArtistProfilePages { get; set; }

		public Release(XElement element)
		{
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			ReleaseReferences = element.Elements().Where(e => e.Name == "ReleaseReference").Select(e => e.Value).ToList();
			ExternalResourceLinks = element.Elements().Where(e => e.Name == "ExternalResourceLink").Select(e => new ExternalResourceLink(e)).ToList();
			SalesReportingProxyReleaseIds = element.Elements().Where(e => e.Name == "SalesReportingProxyReleaseId").Select(e => new SalesReportingProxyReleaseId(e)).ToList();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			ReleaseResourceReferenceList = element.Elements().Where(e => e.Name == "ReleaseResourceReferenceList").Select(e => new ReleaseResourceReferenceList(e)).SingleOrDefault();
			ResourceOmissionReason = element.Elements().Where(e => e.Name == "ResourceOmissionReason").Select(e => e.Value).SingleOrDefault();
			ReleaseCollectionReferenceList = element.Elements().Where(e => e.Name == "ReleaseCollectionReferenceList").Select(e => new ReleaseCollectionReferenceList(e)).SingleOrDefault();
			ReleaseTypes = element.Elements().Where(e => e.Name == "ReleaseType").Select(e => e.Value).ToList();
			ReleaseDetailsByTerritorys = element.Elements().Where(e => e.Name == "ReleaseDetailsByTerritory").Select(e => new ReleaseDetailsByTerritory(e)).ToList();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			ArtistProfilePages = element.Elements().Where(e => e.Name == "ArtistProfilePage").Select(e => new WebPage(e)).ToList();
		}

		public Release()
		{ }
	}

	public class ReleaseDeal
	{
		public IList<string> DealReleaseReferences { get; set; }
		public IList<Deal> Deals { get; set; }
		public string EffectiveDate { get; set; }

		public ReleaseDeal(XElement element)
		{
			DealReleaseReferences = element.Elements().Where(e => e.Name == "DealReleaseReference").Select(e => e.Value).ToList();
			Deals = element.Elements().Where(e => e.Name == "Deal").Select(e => new Deal(e)).ToList();
			EffectiveDate = element.Elements().Where(e => e.Name == "EffectiveDate").Select(e => e.Value).SingleOrDefault();
		}

		public ReleaseDeal()
		{ }
	}

	public class ReleaseDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<string> DisplayArtistNames { get; set; }
		public IList<string> LabelNames { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public string IsMultiArtistCompilation { get; set; }
		public IList<AdministratingRecordCompany> AdministratingRecordCompanys { get; set; }
		public IList<string> ReleaseTypes { get; set; }
		public IList<RelatedRelease> RelatedReleases { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<AvRating> AvRatings { get; set; }
		public string MarketingComment { get; set; }
		public IList<ResourceGroup> ResourceGroups { get; set; }
		public IList<Genre> Genres { get; set; }
		public string OriginalReleaseDate { get; set; }
		public string OriginalDigitalReleaseDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<Character> Characters { get; set; }
		public string NumberOfUnitsPerPhysicalRelease { get; set; }

		public ReleaseDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			DisplayArtistNames = element.Elements().Where(e => e.Name == "DisplayArtistName").Select(e => e.Value).ToList();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			IsMultiArtistCompilation = element.Elements().Where(e => e.Name == "IsMultiArtistCompilation").Select(e => e.Value).SingleOrDefault();
			AdministratingRecordCompanys = element.Elements().Where(e => e.Name == "AdministratingRecordCompany").Select(e => new AdministratingRecordCompany(e)).ToList();
			ReleaseTypes = element.Elements().Where(e => e.Name == "ReleaseType").Select(e => e.Value).ToList();
			RelatedReleases = element.Elements().Where(e => e.Name == "RelatedRelease").Select(e => new RelatedRelease(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			AvRatings = element.Elements().Where(e => e.Name == "AvRating").Select(e => new AvRating(e)).ToList();
			MarketingComment = element.Elements().Where(e => e.Name == "MarketingComment").Select(e => e.Value).SingleOrDefault();
			ResourceGroups = element.Elements().Where(e => e.Name == "ResourceGroup").Select(e => new ResourceGroup(e)).ToList();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			OriginalReleaseDate = element.Elements().Where(e => e.Name == "OriginalReleaseDate").Select(e => e.Value).SingleOrDefault();
			OriginalDigitalReleaseDate = element.Elements().Where(e => e.Name == "OriginalDigitalReleaseDate").Select(e => e.Value).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			Characters = element.Elements().Where(e => e.Name == "Character").Select(e => new Character(e)).ToList();
			NumberOfUnitsPerPhysicalRelease = element.Elements().Where(e => e.Name == "NumberOfUnitsPerPhysicalRelease").Select(e => e.Value).SingleOrDefault();
		}

		public ReleaseDetailsByTerritory()
		{ }
	}

	public class ReleaseList
	{
		public IList<Release> Releases { get; set; }

		public ReleaseList(XElement element)
		{
			Releases = element.Elements().Where(e => e.Name == "Release").Select(e => new Release(e)).ToList();
		}

		public ReleaseList()
		{ }
	}

	public class ResourceGroup
	{
		public IList<Title> Titles { get; set; }
		public string SequenceNumber { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<ResourceGroup> ResourceGroups { get; set; }
		public IList<ResourceGroupContentItem> ResourceGroupContentItems { get; set; }
		public ResourceGroupResourceReferenceList ResourceGroupResourceReferenceList { get; set; }
		public string ResourceGroupReleaseReference { get; set; }
		public ReleaseId ReleaseId { get; set; }

		public ResourceGroup(XElement element)
		{
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			ResourceGroups = element.Elements().Where(e => e.Name == "ResourceGroup").Select(e => new ResourceGroup(e)).ToList();
			ResourceGroupContentItems = element.Elements().Where(e => e.Name == "ResourceGroupContentItem").Select(e => new ResourceGroupContentItem(e)).ToList();
			ResourceGroupResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceGroupResourceReferenceList").Select(e => new ResourceGroupResourceReferenceList(e)).SingleOrDefault();
			ResourceGroupReleaseReference = element.Elements().Where(e => e.Name == "ResourceGroupReleaseReference").Select(e => e.Value).SingleOrDefault();
			ReleaseId = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).SingleOrDefault();
		}

		public ResourceGroup()
		{ }
	}

	public class ResourceGroupContentItem
	{
		public string SequenceNumber { get; set; }
		public string SequenceSubNumber { get; set; }
		public IList<string> ResourceTypes { get; set; }
		public string ReleaseResourceReference { get; set; }
		public IList<string> LinkedReleaseResourceReferences { get; set; }
		public string ResourceGroupContentItemReleaseReference { get; set; }
		public ReleaseId ReleaseId { get; set; }
		public string Duration { get; set; }
		public string IsHiddenResource { get; set; }
		public string IsBonusResource { get; set; }

		public ResourceGroupContentItem(XElement element)
		{
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			SequenceSubNumber = element.Elements().Where(e => e.Name == "SequenceSubNumber").Select(e => e.Value).SingleOrDefault();
			ResourceTypes = element.Elements().Where(e => e.Name == "ResourceType").Select(e => e.Value).ToList();
			ReleaseResourceReference = element.Elements().Where(e => e.Name == "ReleaseResourceReference").Select(e => e.Value).SingleOrDefault();
			LinkedReleaseResourceReferences = element.Elements().Where(e => e.Name == "LinkedReleaseResourceReference").Select(e => e.Value).ToList();
			ResourceGroupContentItemReleaseReference = element.Elements().Where(e => e.Name == "ResourceGroupContentItemReleaseReference").Select(e => e.Value).SingleOrDefault();
			ReleaseId = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			IsHiddenResource = element.Elements().Where(e => e.Name == "IsHiddenResource").Select(e => e.Value).SingleOrDefault();
			IsBonusResource = element.Elements().Where(e => e.Name == "IsBonusResource").Select(e => e.Value).SingleOrDefault();
		}

		public ResourceGroupContentItem()
		{ }
	}

	public class ResourceList
	{
		public IList<SoundRecording> SoundRecordings { get; set; }
		public IList<MIDI> MIDIs { get; set; }
		public IList<Video> Videos { get; set; }
		public IList<Image> Images { get; set; }
		public IList<Text> Texts { get; set; }
		public IList<SheetMusic> SheetMusics { get; set; }
		public IList<Software> Softwares { get; set; }
		public IList<UserDefinedResource> UserDefinedResources { get; set; }

		public ResourceList(XElement element)
		{
			SoundRecordings = element.Elements().Where(e => e.Name == "SoundRecording").Select(e => new SoundRecording(e)).ToList();
			MIDIs = element.Elements().Where(e => e.Name == "MIDI").Select(e => new MIDI(e)).ToList();
			Videos = element.Elements().Where(e => e.Name == "Video").Select(e => new Video(e)).ToList();
			Images = element.Elements().Where(e => e.Name == "Image").Select(e => new Image(e)).ToList();
			Texts = element.Elements().Where(e => e.Name == "Text").Select(e => new Text(e)).ToList();
			SheetMusics = element.Elements().Where(e => e.Name == "SheetMusic").Select(e => new SheetMusic(e)).ToList();
			Softwares = element.Elements().Where(e => e.Name == "Software").Select(e => new Software(e)).ToList();
			UserDefinedResources = element.Elements().Where(e => e.Name == "UserDefinedResource").Select(e => new UserDefinedResource(e)).ToList();
		}

		public ResourceList()
		{ }
	}

	public class ResourceUsage
	{
		public IList<string> DealResourceReferences { get; set; }
		public IList<Usage> Usages { get; set; }

		public ResourceUsage(XElement element)
		{
			DealResourceReferences = element.Elements().Where(e => e.Name == "DealResourceReference").Select(e => e.Value).ToList();
			Usages = element.Elements().Where(e => e.Name == "Usage").Select(e => new Usage(e)).ToList();
		}

		public ResourceUsage()
		{ }
	}

	public class RightsClaimPolicy
	{
		public Condition Condition { get; set; }
		public string RightsClaimPolicyType { get; set; }

		public RightsClaimPolicy(XElement element)
		{
			Condition = element.Elements().Where(e => e.Name == "Condition").Select(e => new Condition(e)).SingleOrDefault();
			RightsClaimPolicyType = element.Elements().Where(e => e.Name == "RightsClaimPolicyType").Select(e => e.Value).SingleOrDefault();
		}

		public RightsClaimPolicy()
		{ }
	}

	public class SheetMusic
	{
		public string SheetMusicType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<SheetMusicId> SheetMusicIds { get; set; }
		public IList<MusicalWorkId> IndirectSheetMusicIds { get; set; }
		public string ResourceReference { get; set; }
		public string LanguageOfLyrics { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public string CreationDate { get; set; }
		public IList<SheetMusicDetailsByTerritory> SheetMusicDetailsByTerritorys { get; set; }

		public SheetMusic(XElement element)
		{
			SheetMusicType = element.Elements().Where(e => e.Name == "SheetMusicType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			SheetMusicIds = element.Elements().Where(e => e.Name == "SheetMusicId").Select(e => new SheetMusicId(e)).ToList();
			IndirectSheetMusicIds = element.Elements().Where(e => e.Name == "IndirectSheetMusicId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			LanguageOfLyrics = element.Elements().Where(e => e.Name == "LanguageOfLyrics").Select(e => e.Value).SingleOrDefault();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			SheetMusicDetailsByTerritorys = element.Elements().Where(e => e.Name == "SheetMusicDetailsByTerritory").Select(e => new SheetMusicDetailsByTerritory(e)).ToList();
		}

		public SheetMusic()
		{ }
	}

	public class SheetMusicDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<TechnicalSheetMusicDetails> TechnicalSheetMusicDetails { get; set; }

		public SheetMusicDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			TechnicalSheetMusicDetails = element.Elements().Where(e => e.Name == "TechnicalSheetMusicDetails").Select(e => new TechnicalSheetMusicDetails(e)).ToList();
		}

		public SheetMusicDetailsByTerritory()
		{ }
	}

	public class Software
	{
		public string SoftwareType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<SoftwareId> SoftwareIds { get; set; }
		public IList<MusicalWorkId> IndirectSoftwareIds { get; set; }
		public string ResourceReference { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public IList<Title> Titles { get; set; }
		public string CreationDate { get; set; }
		public IList<SoftwareDetailsByTerritory> SoftwareDetailsByTerritorys { get; set; }

		public Software(XElement element)
		{
			SoftwareType = element.Elements().Where(e => e.Name == "SoftwareType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			SoftwareIds = element.Elements().Where(e => e.Name == "SoftwareId").Select(e => new SoftwareId(e)).ToList();
			IndirectSoftwareIds = element.Elements().Where(e => e.Name == "IndirectSoftwareId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			SoftwareDetailsByTerritorys = element.Elements().Where(e => e.Name == "SoftwareDetailsByTerritory").Select(e => new SoftwareDetailsByTerritory(e)).ToList();
		}

		public Software()
		{ }
	}

	public class SoftwareDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<TechnicalSoftwareDetails> TechnicalSoftwareDetails { get; set; }

		public SoftwareDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			TechnicalSoftwareDetails = element.Elements().Where(e => e.Name == "TechnicalSoftwareDetails").Select(e => new TechnicalSoftwareDetails(e)).ToList();
		}

		public SoftwareDetailsByTerritory()
		{ }
	}

	public class SoundRecording
	{
		public string SoundRecordingType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<SoundRecordingId> SoundRecordingIds { get; set; }
		public IList<MusicalWorkId> IndirectSoundRecordingIds { get; set; }
		public string ResourceReference { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public string InstrumentationDescription { get; set; }
		public string IsMedley { get; set; }
		public string IsPotpourri { get; set; }
		public string IsInstrumental { get; set; }
		public string IsBackground { get; set; }
		public string IsHiddenResource { get; set; }
		public string IsBonusResource { get; set; }
		public string IsComputerGenerated { get; set; }
		public string NoSilenceBefore { get; set; }
		public string NoSilenceAfter { get; set; }
		public string PerformerInformationRequired { get; set; }
		public string LanguageOfPerformance { get; set; }
		public string Duration { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public SoundRecordingCollectionReferenceList SoundRecordingCollectionReferenceList { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public string CreationDate { get; set; }
		public string MasteredDate { get; set; }
		public IList<SoundRecordingDetailsByTerritory> SoundRecordingDetailsByTerritorys { get; set; }

		public SoundRecording(XElement element)
		{
			SoundRecordingType = element.Elements().Where(e => e.Name == "SoundRecordingType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			SoundRecordingIds = element.Elements().Where(e => e.Name == "SoundRecordingId").Select(e => new SoundRecordingId(e)).ToList();
			IndirectSoundRecordingIds = element.Elements().Where(e => e.Name == "IndirectSoundRecordingId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			InstrumentationDescription = element.Elements().Where(e => e.Name == "InstrumentationDescription").Select(e => e.Value).SingleOrDefault();
			IsMedley = element.Elements().Where(e => e.Name == "IsMedley").Select(e => e.Value).SingleOrDefault();
			IsPotpourri = element.Elements().Where(e => e.Name == "IsPotpourri").Select(e => e.Value).SingleOrDefault();
			IsInstrumental = element.Elements().Where(e => e.Name == "IsInstrumental").Select(e => e.Value).SingleOrDefault();
			IsBackground = element.Elements().Where(e => e.Name == "IsBackground").Select(e => e.Value).SingleOrDefault();
			IsHiddenResource = element.Elements().Where(e => e.Name == "IsHiddenResource").Select(e => e.Value).SingleOrDefault();
			IsBonusResource = element.Elements().Where(e => e.Name == "IsBonusResource").Select(e => e.Value).SingleOrDefault();
			IsComputerGenerated = element.Elements().Where(e => e.Name == "IsComputerGenerated").Select(e => e.Value).SingleOrDefault();
			NoSilenceBefore = element.Elements().Where(e => e.Name == "NoSilenceBefore").Select(e => e.Value).SingleOrDefault();
			NoSilenceAfter = element.Elements().Where(e => e.Name == "NoSilenceAfter").Select(e => e.Value).SingleOrDefault();
			PerformerInformationRequired = element.Elements().Where(e => e.Name == "PerformerInformationRequired").Select(e => e.Value).SingleOrDefault();
			LanguageOfPerformance = element.Elements().Where(e => e.Name == "LanguageOfPerformance").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			SoundRecordingCollectionReferenceList = element.Elements().Where(e => e.Name == "SoundRecordingCollectionReferenceList").Select(e => new SoundRecordingCollectionReferenceList(e)).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			MasteredDate = element.Elements().Where(e => e.Name == "MasteredDate").Select(e => e.Value).SingleOrDefault();
			SoundRecordingDetailsByTerritorys = element.Elements().Where(e => e.Name == "SoundRecordingDetailsByTerritory").Select(e => new SoundRecordingDetailsByTerritory(e)).ToList();
		}

		public SoundRecording()
		{ }
	}

	public class SoundRecordingDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<PLine> PLines { get; set; }
		public string CourtesyLine { get; set; }
		public string SequenceNumber { get; set; }
		public IList<HostSoundCarrier> HostSoundCarriers { get; set; }
		public string MarketingComment { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<AvRating> AvRatings { get; set; }
		public IList<TechnicalSoundRecordingDetails> TechnicalSoundRecordingDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }

		public SoundRecordingDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			HostSoundCarriers = element.Elements().Where(e => e.Name == "HostSoundCarrier").Select(e => new HostSoundCarrier(e)).ToList();
			MarketingComment = element.Elements().Where(e => e.Name == "MarketingComment").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			AvRatings = element.Elements().Where(e => e.Name == "AvRating").Select(e => new AvRating(e)).ToList();
			TechnicalSoundRecordingDetails = element.Elements().Where(e => e.Name == "TechnicalSoundRecordingDetails").Select(e => new TechnicalSoundRecordingDetails(e)).ToList();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
		}

		public SoundRecordingDetailsByTerritory()
		{ }
	}

	public class SoundRecordingPreviewDetails
	{
		public string PartType { get; set; }
		public string StartPoint { get; set; }
		public string EndPoint { get; set; }
		public string Duration { get; set; }
		public string TopLeftCorner { get; set; }
		public string BottomRightCorner { get; set; }
		public string ExpressionType { get; set; }

		public SoundRecordingPreviewDetails(XElement element)
		{
			PartType = element.Elements().Where(e => e.Name == "PartType").Select(e => e.Value).SingleOrDefault();
			StartPoint = element.Elements().Where(e => e.Name == "StartPoint").Select(e => e.Value).SingleOrDefault();
			EndPoint = element.Elements().Where(e => e.Name == "EndPoint").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			TopLeftCorner = element.Elements().Where(e => e.Name == "TopLeftCorner").Select(e => e.Value).SingleOrDefault();
			BottomRightCorner = element.Elements().Where(e => e.Name == "BottomRightCorner").Select(e => e.Value).SingleOrDefault();
			ExpressionType = element.Elements().Where(e => e.Name == "ExpressionType").Select(e => e.Value).SingleOrDefault();
		}

		public SoundRecordingPreviewDetails()
		{ }
	}

	public class TechnicalImageDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string ContainerFormat { get; set; }
		public string ImageCodecType { get; set; }
		public string ImageHeight { get; set; }
		public string ImageWidth { get; set; }
		public string AspectRatio { get; set; }
		public string ColorDepth { get; set; }
		public string ImageResolution { get; set; }
		public string IsPreview { get; set; }
		public PreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalImageDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			ContainerFormat = element.Elements().Where(e => e.Name == "ContainerFormat").Select(e => e.Value).SingleOrDefault();
			ImageCodecType = element.Elements().Where(e => e.Name == "ImageCodecType").Select(e => e.Value).SingleOrDefault();
			ImageHeight = element.Elements().Where(e => e.Name == "ImageHeight").Select(e => e.Value).SingleOrDefault();
			ImageWidth = element.Elements().Where(e => e.Name == "ImageWidth").Select(e => e.Value).SingleOrDefault();
			AspectRatio = element.Elements().Where(e => e.Name == "AspectRatio").Select(e => e.Value).SingleOrDefault();
			ColorDepth = element.Elements().Where(e => e.Name == "ColorDepth").Select(e => e.Value).SingleOrDefault();
			ImageResolution = element.Elements().Where(e => e.Name == "ImageResolution").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new PreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalImageDetails()
		{ }
	}

	public class TechnicalMidiDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string Duration { get; set; }
		public string ResourceProcessingRequired { get; set; }
		public string UsableResourceDuration { get; set; }
		public string IsPreview { get; set; }
		public SoundRecordingPreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public string NumberOfVoices { get; set; }
		public string SoundProcessorType { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalMidiDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			ResourceProcessingRequired = element.Elements().Where(e => e.Name == "ResourceProcessingRequired").Select(e => e.Value).SingleOrDefault();
			UsableResourceDuration = element.Elements().Where(e => e.Name == "UsableResourceDuration").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new SoundRecordingPreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			NumberOfVoices = element.Elements().Where(e => e.Name == "NumberOfVoices").Select(e => e.Value).SingleOrDefault();
			SoundProcessorType = element.Elements().Where(e => e.Name == "SoundProcessorType").Select(e => e.Value).SingleOrDefault();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalMidiDetails()
		{ }
	}

	public class TechnicalSheetMusicDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string ContainerFormat { get; set; }
		public string SheetMusicCodecType { get; set; }
		public string IsPreview { get; set; }
		public PreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalSheetMusicDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			ContainerFormat = element.Elements().Where(e => e.Name == "ContainerFormat").Select(e => e.Value).SingleOrDefault();
			SheetMusicCodecType = element.Elements().Where(e => e.Name == "SheetMusicCodecType").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new PreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalSheetMusicDetails()
		{ }
	}

	public class TechnicalSoftwareDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string OperatingSystemType { get; set; }
		public string IsPreview { get; set; }
		public PreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalSoftwareDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			OperatingSystemType = element.Elements().Where(e => e.Name == "OperatingSystemType").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new PreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalSoftwareDetails()
		{ }
	}

	public class TechnicalSoundRecordingDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string ContainerFormat { get; set; }
		public string AudioCodecType { get; set; }
		public string BitRate { get; set; }
		public string NumberOfChannels { get; set; }
		public string SamplingRate { get; set; }
		public string BitsPerSample { get; set; }
		public string Duration { get; set; }
		public string ResourceProcessingRequired { get; set; }
		public string UsableResourceDuration { get; set; }
		public string IsPreview { get; set; }
		public SoundRecordingPreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalSoundRecordingDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			ContainerFormat = element.Elements().Where(e => e.Name == "ContainerFormat").Select(e => e.Value).SingleOrDefault();
			AudioCodecType = element.Elements().Where(e => e.Name == "AudioCodecType").Select(e => e.Value).SingleOrDefault();
			BitRate = element.Elements().Where(e => e.Name == "BitRate").Select(e => e.Value).SingleOrDefault();
			NumberOfChannels = element.Elements().Where(e => e.Name == "NumberOfChannels").Select(e => e.Value).SingleOrDefault();
			SamplingRate = element.Elements().Where(e => e.Name == "SamplingRate").Select(e => e.Value).SingleOrDefault();
			BitsPerSample = element.Elements().Where(e => e.Name == "BitsPerSample").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			ResourceProcessingRequired = element.Elements().Where(e => e.Name == "ResourceProcessingRequired").Select(e => e.Value).SingleOrDefault();
			UsableResourceDuration = element.Elements().Where(e => e.Name == "UsableResourceDuration").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new SoundRecordingPreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalSoundRecordingDetails()
		{ }
	}

	public class TechnicalTextDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string ContainerFormat { get; set; }
		public string TextCodecType { get; set; }
		public string IsPreview { get; set; }
		public PreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalTextDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			ContainerFormat = element.Elements().Where(e => e.Name == "ContainerFormat").Select(e => e.Value).SingleOrDefault();
			TextCodecType = element.Elements().Where(e => e.Name == "TextCodecType").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new PreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalTextDetails()
		{ }
	}

	public class TechnicalUserDefinedResourceDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public IList<string> UserDefinedValues { get; set; }
		public string IsPreview { get; set; }
		public PreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalUserDefinedResourceDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			UserDefinedValues = element.Elements().Where(e => e.Name == "UserDefinedValue").Select(e => e.Value).ToList();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new PreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalUserDefinedResourceDetails()
		{ }
	}

	public class TechnicalVideoDetails
	{
		public string TechnicalResourceDetailsReference { get; set; }
		public string DrmPlatformType { get; set; }
		public string OverallBitRate { get; set; }
		public string ContainerFormat { get; set; }
		public string VideoCodecType { get; set; }
		public string VideoBitRate { get; set; }
		public string FrameRate { get; set; }
		public string ImageHeight { get; set; }
		public string ImageWidth { get; set; }
		public string AspectRatio { get; set; }
		public string ColorDepth { get; set; }
		public string VideoDefinitionType { get; set; }
		public string AudioCodecType { get; set; }
		public string AudioBitRate { get; set; }
		public string NumberOfAudioChannels { get; set; }
		public string AudioSamplingRate { get; set; }
		public string AudioBitsPerSample { get; set; }
		public string Duration { get; set; }
		public string ResourceProcessingRequired { get; set; }
		public string UsableResourceDuration { get; set; }
		public string IsPreview { get; set; }
		public SoundRecordingPreviewDetails PreviewDetails { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public FulfillmentDate ConsumerFulfillmentDate { get; set; }
		public IList<string> FileAvailabilityDescriptions { get; set; }
		public IList<File> Files { get; set; }
		public IList<Fingerprint> Fingerprints { get; set; }

		public TechnicalVideoDetails(XElement element)
		{
			TechnicalResourceDetailsReference = element.Elements().Where(e => e.Name == "TechnicalResourceDetailsReference").Select(e => e.Value).SingleOrDefault();
			DrmPlatformType = element.Elements().Where(e => e.Name == "DrmPlatformType").Select(e => e.Value).SingleOrDefault();
			OverallBitRate = element.Elements().Where(e => e.Name == "OverallBitRate").Select(e => e.Value).SingleOrDefault();
			ContainerFormat = element.Elements().Where(e => e.Name == "ContainerFormat").Select(e => e.Value).SingleOrDefault();
			VideoCodecType = element.Elements().Where(e => e.Name == "VideoCodecType").Select(e => e.Value).SingleOrDefault();
			VideoBitRate = element.Elements().Where(e => e.Name == "VideoBitRate").Select(e => e.Value).SingleOrDefault();
			FrameRate = element.Elements().Where(e => e.Name == "FrameRate").Select(e => e.Value).SingleOrDefault();
			ImageHeight = element.Elements().Where(e => e.Name == "ImageHeight").Select(e => e.Value).SingleOrDefault();
			ImageWidth = element.Elements().Where(e => e.Name == "ImageWidth").Select(e => e.Value).SingleOrDefault();
			AspectRatio = element.Elements().Where(e => e.Name == "AspectRatio").Select(e => e.Value).SingleOrDefault();
			ColorDepth = element.Elements().Where(e => e.Name == "ColorDepth").Select(e => e.Value).SingleOrDefault();
			VideoDefinitionType = element.Elements().Where(e => e.Name == "VideoDefinitionType").Select(e => e.Value).SingleOrDefault();
			AudioCodecType = element.Elements().Where(e => e.Name == "AudioCodecType").Select(e => e.Value).SingleOrDefault();
			AudioBitRate = element.Elements().Where(e => e.Name == "AudioBitRate").Select(e => e.Value).SingleOrDefault();
			NumberOfAudioChannels = element.Elements().Where(e => e.Name == "NumberOfAudioChannels").Select(e => e.Value).SingleOrDefault();
			AudioSamplingRate = element.Elements().Where(e => e.Name == "AudioSamplingRate").Select(e => e.Value).SingleOrDefault();
			AudioBitsPerSample = element.Elements().Where(e => e.Name == "AudioBitsPerSample").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			ResourceProcessingRequired = element.Elements().Where(e => e.Name == "ResourceProcessingRequired").Select(e => e.Value).SingleOrDefault();
			UsableResourceDuration = element.Elements().Where(e => e.Name == "UsableResourceDuration").Select(e => e.Value).SingleOrDefault();
			IsPreview = element.Elements().Where(e => e.Name == "IsPreview").Select(e => e.Value).SingleOrDefault();
			PreviewDetails = element.Elements().Where(e => e.Name == "PreviewDetails").Select(e => new SoundRecordingPreviewDetails(e)).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			ConsumerFulfillmentDate = element.Elements().Where(e => e.Name == "ConsumerFulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			FileAvailabilityDescriptions = element.Elements().Where(e => e.Name == "FileAvailabilityDescription").Select(e => e.Value).ToList();
			Files = element.Elements().Where(e => e.Name == "File").Select(e => new File(e)).ToList();
			Fingerprints = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => new Fingerprint(e)).ToList();
		}

		public TechnicalVideoDetails()
		{ }
	}

	public class Text
	{
		public string TextType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<TextId> TextIds { get; set; }
		public IList<MusicalWorkId> IndirectTextIds { get; set; }
		public string ResourceReference { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public IList<Title> Titles { get; set; }
		public string CreationDate { get; set; }
		public IList<TextDetailsByTerritory> TextDetailsByTerritorys { get; set; }

		public Text(XElement element)
		{
			TextType = element.Elements().Where(e => e.Name == "TextType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			TextIds = element.Elements().Where(e => e.Name == "TextId").Select(e => new TextId(e)).ToList();
			IndirectTextIds = element.Elements().Where(e => e.Name == "IndirectTextId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			TextDetailsByTerritorys = element.Elements().Where(e => e.Name == "TextDetailsByTerritory").Select(e => new TextDetailsByTerritory(e)).ToList();
		}

		public Text()
		{ }
	}

	public class TextDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<TechnicalTextDetails> TechnicalTextDetails { get; set; }

		public TextDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			TechnicalTextDetails = element.Elements().Where(e => e.Name == "TechnicalTextDetails").Select(e => new TechnicalTextDetails(e)).ToList();
		}

		public TextDetailsByTerritory()
		{ }
	}

	public class UserDefinedResource
	{
		public string UserDefinedResourceType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<UserDefinedResourceId> UserDefinedResourceIds { get; set; }
		public IList<MusicalWorkId> IndirectUserDefinedResourceIds { get; set; }
		public string ResourceReference { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<string> UserDefinedValues { get; set; }
		public IList<UserDefinedResourceDetailsByTerritory> UserDefinedResourceDetailsByTerritorys { get; set; }

		public UserDefinedResource(XElement element)
		{
			UserDefinedResourceType = element.Elements().Where(e => e.Name == "UserDefinedResourceType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			UserDefinedResourceIds = element.Elements().Where(e => e.Name == "UserDefinedResourceId").Select(e => new UserDefinedResourceId(e)).ToList();
			IndirectUserDefinedResourceIds = element.Elements().Where(e => e.Name == "IndirectUserDefinedResourceId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			UserDefinedValues = element.Elements().Where(e => e.Name == "UserDefinedValue").Select(e => e.Value).ToList();
			UserDefinedResourceDetailsByTerritorys = element.Elements().Where(e => e.Name == "UserDefinedResourceDetailsByTerritory").Select(e => new UserDefinedResourceDetailsByTerritory(e)).ToList();
		}

		public UserDefinedResource()
		{ }
	}

	public class UserDefinedResourceDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<string> UserDefinedValues { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<TechnicalUserDefinedResourceDetails> TechnicalUserDefinedResourceDetails { get; set; }

		public UserDefinedResourceDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			UserDefinedValues = element.Elements().Where(e => e.Name == "UserDefinedValue").Select(e => e.Value).ToList();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			TechnicalUserDefinedResourceDetails = element.Elements().Where(e => e.Name == "TechnicalUserDefinedResourceDetails").Select(e => new TechnicalUserDefinedResourceDetails(e)).ToList();
		}

		public UserDefinedResourceDetailsByTerritory()
		{ }
	}

	public class Video
	{
		public string VideoType { get; set; }
		public string IsArtistRelated { get; set; }
		public IList<VideoId> VideoIds { get; set; }
		public IList<MusicalWorkId> IndirectVideoIds { get; set; }
		public string ResourceReference { get; set; }
		public IList<VideoCueSheetReference> VideoCueSheetReferences { get; set; }
		public string ReasonForCueSheetAbsence { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public IList<Title> Titles { get; set; }
		public string InstrumentationDescription { get; set; }
		public string IsMedley { get; set; }
		public string IsPotpourri { get; set; }
		public string IsInstrumental { get; set; }
		public string IsBackground { get; set; }
		public string IsHiddenResource { get; set; }
		public string IsBonusResource { get; set; }
		public string NoSilenceBefore { get; set; }
		public string NoSilenceAfter { get; set; }
		public string PerformerInformationRequired { get; set; }
		public IList<string> LanguageOfPerformances { get; set; }
		public string Duration { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public SoundRecordingCollectionReferenceList VideoCollectionReferenceList { get; set; }
		public ResourceMusicalWorkReferenceList ResourceMusicalWorkReferenceList { get; set; }
		public ResourceContainedResourceReferenceList ResourceContainedResourceReferenceList { get; set; }
		public string CreationDate { get; set; }
		public string MasteredDate { get; set; }
		public IList<VideoDetailsByTerritory> VideoDetailsByTerritorys { get; set; }

		public Video(XElement element)
		{
			VideoType = element.Elements().Where(e => e.Name == "VideoType").Select(e => e.Value).SingleOrDefault();
			IsArtistRelated = element.Elements().Where(e => e.Name == "IsArtistRelated").Select(e => e.Value).SingleOrDefault();
			VideoIds = element.Elements().Where(e => e.Name == "VideoId").Select(e => new VideoId(e)).ToList();
			IndirectVideoIds = element.Elements().Where(e => e.Name == "IndirectVideoId").Select(e => new MusicalWorkId(e)).ToList();
			ResourceReference = element.Elements().Where(e => e.Name == "ResourceReference").Select(e => e.Value).SingleOrDefault();
			VideoCueSheetReferences = element.Elements().Where(e => e.Name == "VideoCueSheetReference").Select(e => new VideoCueSheetReference(e)).ToList();
			ReasonForCueSheetAbsence = element.Elements().Where(e => e.Name == "ReasonForCueSheetAbsence").Select(e => e.Value).SingleOrDefault();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			InstrumentationDescription = element.Elements().Where(e => e.Name == "InstrumentationDescription").Select(e => e.Value).SingleOrDefault();
			IsMedley = element.Elements().Where(e => e.Name == "IsMedley").Select(e => e.Value).SingleOrDefault();
			IsPotpourri = element.Elements().Where(e => e.Name == "IsPotpourri").Select(e => e.Value).SingleOrDefault();
			IsInstrumental = element.Elements().Where(e => e.Name == "IsInstrumental").Select(e => e.Value).SingleOrDefault();
			IsBackground = element.Elements().Where(e => e.Name == "IsBackground").Select(e => e.Value).SingleOrDefault();
			IsHiddenResource = element.Elements().Where(e => e.Name == "IsHiddenResource").Select(e => e.Value).SingleOrDefault();
			IsBonusResource = element.Elements().Where(e => e.Name == "IsBonusResource").Select(e => e.Value).SingleOrDefault();
			NoSilenceBefore = element.Elements().Where(e => e.Name == "NoSilenceBefore").Select(e => e.Value).SingleOrDefault();
			NoSilenceAfter = element.Elements().Where(e => e.Name == "NoSilenceAfter").Select(e => e.Value).SingleOrDefault();
			PerformerInformationRequired = element.Elements().Where(e => e.Name == "PerformerInformationRequired").Select(e => e.Value).SingleOrDefault();
			LanguageOfPerformances = element.Elements().Where(e => e.Name == "LanguageOfPerformance").Select(e => e.Value).ToList();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			VideoCollectionReferenceList = element.Elements().Where(e => e.Name == "VideoCollectionReferenceList").Select(e => new SoundRecordingCollectionReferenceList(e)).SingleOrDefault();
			ResourceMusicalWorkReferenceList = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReferenceList").Select(e => new ResourceMusicalWorkReferenceList(e)).SingleOrDefault();
			ResourceContainedResourceReferenceList = element.Elements().Where(e => e.Name == "ResourceContainedResourceReferenceList").Select(e => new ResourceContainedResourceReferenceList(e)).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			MasteredDate = element.Elements().Where(e => e.Name == "MasteredDate").Select(e => e.Value).SingleOrDefault();
			VideoDetailsByTerritorys = element.Elements().Where(e => e.Name == "VideoDetailsByTerritory").Select(e => new VideoDetailsByTerritory(e)).ToList();
		}

		public Video()
		{ }
	}

	public class VideoDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<PLine> PLines { get; set; }
		public string CourtesyLine { get; set; }
		public string SequenceNumber { get; set; }
		public IList<HostSoundCarrier> HostSoundCarriers { get; set; }
		public string MarketingComment { get; set; }
		public IList<Genre> Genres { get; set; }
		public IList<string> ParentalWarningTypes { get; set; }
		public IList<AvRating> AvRatings { get; set; }
		public FulfillmentDate FulfillmentDate { get; set; }
		public IList<string> Keywords { get; set; }
		public string Synopsis { get; set; }
		public IList<CLine> CLines { get; set; }
		public IList<TechnicalVideoDetails> TechnicalVideoDetails { get; set; }
		public IList<Character> Characters { get; set; }

		public VideoDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			HostSoundCarriers = element.Elements().Where(e => e.Name == "HostSoundCarrier").Select(e => new HostSoundCarrier(e)).ToList();
			MarketingComment = element.Elements().Where(e => e.Name == "MarketingComment").Select(e => e.Value).SingleOrDefault();
			Genres = element.Elements().Where(e => e.Name == "Genre").Select(e => new Genre(e)).ToList();
			ParentalWarningTypes = element.Elements().Where(e => e.Name == "ParentalWarningType").Select(e => e.Value).ToList();
			AvRatings = element.Elements().Where(e => e.Name == "AvRating").Select(e => new AvRating(e)).ToList();
			FulfillmentDate = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => new FulfillmentDate(e)).SingleOrDefault();
			Keywords = element.Elements().Where(e => e.Name == "Keywords").Select(e => e.Value).ToList();
			Synopsis = element.Elements().Where(e => e.Name == "Synopsis").Select(e => e.Value).SingleOrDefault();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			TechnicalVideoDetails = element.Elements().Where(e => e.Name == "TechnicalVideoDetails").Select(e => new TechnicalVideoDetails(e)).ToList();
			Characters = element.Elements().Where(e => e.Name == "Character").Select(e => new Character(e)).ToList();
		}

		public VideoDetailsByTerritory()
		{ }
	}

	public class WebPolicy
	{
		public Condition Condition { get; set; }
		public string AccessBlockingRequested { get; set; }
		public string AccessLimitation { get; set; }
		public string EmbeddingAllowed { get; set; }
		public string UserRatingAllowed { get; set; }
		public string UserCommentAllowed { get; set; }
		public string UserResponsesAllowed { get; set; }
		public string SyndicationAllowed { get; set; }

		public WebPolicy(XElement element)
		{
			Condition = element.Elements().Where(e => e.Name == "Condition").Select(e => new Condition(e)).SingleOrDefault();
			AccessBlockingRequested = element.Elements().Where(e => e.Name == "AccessBlockingRequested").Select(e => e.Value).SingleOrDefault();
			AccessLimitation = element.Elements().Where(e => e.Name == "AccessLimitation").Select(e => e.Value).SingleOrDefault();
			EmbeddingAllowed = element.Elements().Where(e => e.Name == "EmbeddingAllowed").Select(e => e.Value).SingleOrDefault();
			UserRatingAllowed = element.Elements().Where(e => e.Name == "UserRatingAllowed").Select(e => e.Value).SingleOrDefault();
			UserCommentAllowed = element.Elements().Where(e => e.Name == "UserCommentAllowed").Select(e => e.Value).SingleOrDefault();
			UserResponsesAllowed = element.Elements().Where(e => e.Name == "UserResponsesAllowed").Select(e => e.Value).SingleOrDefault();
			SyndicationAllowed = element.Elements().Where(e => e.Name == "SyndicationAllowed").Select(e => e.Value).SingleOrDefault();
		}

		public WebPolicy()
		{ }
	}

	public class AdministratingRecordCompany
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }

		public AdministratingRecordCompany(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
		}

		public AdministratingRecordCompany()
		{ }
	}

	public class AmountByUseAndDistributionChannelType
	{
		public string Amount { get; set; }
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }

		public AmountByUseAndDistributionChannelType(XElement element)
		{
			Amount = element.Elements().Where(e => e.Name == "Amount").Select(e => e.Value).SingleOrDefault();
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
		}

		public AmountByUseAndDistributionChannelType()
		{ }
	}

	public class AmountPerCollection
	{
		public string Amount { get; set; }
		public string CollectionType { get; set; }

		public AmountPerCollection(XElement element)
		{
			Amount = element.Elements().Where(e => e.Name == "Amount").Select(e => e.Value).SingleOrDefault();
			CollectionType = element.Elements().Where(e => e.Name == "CollectionType").Select(e => e.Value).SingleOrDefault();
		}

		public AmountPerCollection()
		{ }
	}

	public class Artist
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public IList<string> ArtistRoles { get; set; }

		public Artist(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			ArtistRoles = element.Elements().Where(e => e.Name == "ArtistRole").Select(e => e.Value).ToList();
		}

		public Artist()
		{ }
	}

	public class AvRating
	{
		public string RatingText { get; set; }
		public string RatingAgency { get; set; }

		public AvRating(XElement element)
		{
			RatingText = element.Elements().Where(e => e.Name == "RatingText").Select(e => e.Value).SingleOrDefault();
			RatingAgency = element.Elements().Where(e => e.Name == "RatingAgency").Select(e => e.Value).SingleOrDefault();
		}

		public AvRating()
		{ }
	}

	public class CLine
	{
		public string Year { get; set; }
		public string CLineCompany { get; set; }
		public string CLineText { get; set; }

		public CLine(XElement element)
		{
			Year = element.Elements().Where(e => e.Name == "Year").Select(e => e.Value).SingleOrDefault();
			CLineCompany = element.Elements().Where(e => e.Name == "CLineCompany").Select(e => e.Value).SingleOrDefault();
			CLineText = element.Elements().Where(e => e.Name == "CLineText").Select(e => e.Value).SingleOrDefault();
		}

		public CLine()
		{ }
	}

	public class Character
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public ResourceContributor ResourceContributor { get; set; }

		public Character(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			ResourceContributor = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).SingleOrDefault();
		}

		public Character()
		{ }
	}

	public class Collection1
	{
		public IList<CollectionId> CollectionIds { get; set; }
		public IList<string> CollectionTypes { get; set; }
		public string CollectionReference { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> Contributors { get; set; }
		public CollectionCollectionReferenceList CollectionCollectionReferenceList { get; set; }
		public string IsComplete { get; set; }
		public string DurationOfMusicalContent { get; set; }
		public string CreationDate { get; set; }
		public string OriginalReleaseDate { get; set; }
		public string OriginalLanguage { get; set; }
		public IList<CollectionDetailsByTerritory1> CollectionDetailsByTerritorys { get; set; }
		public CollectionResourceReferenceList1 CollectionResourceReferenceList { get; set; }

		public Collection1(XElement element)
		{
			CollectionIds = element.Elements().Where(e => e.Name == "CollectionId").Select(e => new CollectionId(e)).ToList();
			CollectionTypes = element.Elements().Where(e => e.Name == "CollectionType").Select(e => e.Value).ToList();
			CollectionReference = element.Elements().Where(e => e.Name == "CollectionReference").Select(e => e.Value).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			Contributors = element.Elements().Where(e => e.Name == "Contributor").Select(e => new ResourceContributor(e)).ToList();
			CollectionCollectionReferenceList = element.Elements().Where(e => e.Name == "CollectionCollectionReferenceList").Select(e => new CollectionCollectionReferenceList(e)).SingleOrDefault();
			IsComplete = element.Elements().Where(e => e.Name == "IsComplete").Select(e => e.Value).SingleOrDefault();
			DurationOfMusicalContent = element.Elements().Where(e => e.Name == "DurationOfMusicalContent").Select(e => e.Value).SingleOrDefault();
			CreationDate = element.Elements().Where(e => e.Name == "CreationDate").Select(e => e.Value).SingleOrDefault();
			OriginalReleaseDate = element.Elements().Where(e => e.Name == "OriginalReleaseDate").Select(e => e.Value).SingleOrDefault();
			OriginalLanguage = element.Elements().Where(e => e.Name == "OriginalLanguage").Select(e => e.Value).SingleOrDefault();
			CollectionDetailsByTerritorys = element.Elements().Where(e => e.Name == "CollectionDetailsByTerritory").Select(e => new CollectionDetailsByTerritory1(e)).ToList();
			CollectionResourceReferenceList = element.Elements().Where(e => e.Name == "CollectionResourceReferenceList").Select(e => new CollectionResourceReferenceList1(e)).SingleOrDefault();
		}

		public Collection1()
		{ }
	}

	public class CollectionCollectionReference
	{
		public string SequenceNumber { get; set; }
		public string CollectionCollectionReferenceProp { get; set; }
		public string StartTime { get; set; }
		public string Duration { get; set; }
		public string EndTime { get; set; }
		public string InclusionDate { get; set; }

		public CollectionCollectionReference(XElement element)
		{
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			CollectionCollectionReferenceProp = element.Elements().Where(e => e.Name == "CollectionCollectionReference").Select(e => e.Value).SingleOrDefault();
			StartTime = element.Elements().Where(e => e.Name == "StartTime").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			EndTime = element.Elements().Where(e => e.Name == "EndTime").Select(e => e.Value).SingleOrDefault();
			InclusionDate = element.Elements().Where(e => e.Name == "InclusionDate").Select(e => e.Value).SingleOrDefault();
		}

		public CollectionCollectionReference()
		{ }
	}

	public class CollectionCollectionReferenceList
	{
		public string NumberOfCollections { get; set; }
		public IList<CollectionCollectionReference> CollectionCollectionReferences { get; set; }

		public CollectionCollectionReferenceList(XElement element)
		{
			NumberOfCollections = element.Elements().Where(e => e.Name == "NumberOfCollections").Select(e => e.Value).SingleOrDefault();
			CollectionCollectionReferences = element.Elements().Where(e => e.Name == "CollectionCollectionReference").Select(e => new CollectionCollectionReference(e)).ToList();
		}

		public CollectionCollectionReferenceList()
		{ }
	}

	public class CollectionDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> Contributors { get; set; }
		public string IsComplete { get; set; }

		public CollectionDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			Contributors = element.Elements().Where(e => e.Name == "Contributor").Select(e => new ResourceContributor(e)).ToList();
			IsComplete = element.Elements().Where(e => e.Name == "IsComplete").Select(e => e.Value).SingleOrDefault();
		}

		public CollectionDetailsByTerritory1()
		{ }
	}

	public class CollectionId
	{
		public string GRid { get; set; }
		public string ISRC { get; set; }
		public string ISAN { get; set; }
		public string VISAN { get; set; }
		public string ICPN { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public CollectionId(XElement element)
		{
			GRid = element.Elements().Where(e => e.Name == "GRid").Select(e => e.Value).SingleOrDefault();
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			ISAN = element.Elements().Where(e => e.Name == "ISAN").Select(e => e.Value).SingleOrDefault();
			VISAN = element.Elements().Where(e => e.Name == "VISAN").Select(e => e.Value).SingleOrDefault();
			ICPN = element.Elements().Where(e => e.Name == "ICPN").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public CollectionId()
		{ }
	}

	public class CollectionList1
	{
		public IList<Collection1> Collections { get; set; }

		public CollectionList1(XElement element)
		{
			Collections = element.Elements().Where(e => e.Name == "Collection").Select(e => new Collection1(e)).ToList();
		}

		public CollectionList1()
		{ }
	}

	public class CollectionResourceReferenceList1
	{
		public IList<string> CollectionResourceReferences { get; set; }

		public CollectionResourceReferenceList1(XElement element)
		{
			CollectionResourceReferences = element.Elements().Where(e => e.Name == "CollectionResourceReference").Select(e => e.Value).ToList();
		}

		public CollectionResourceReferenceList1()
		{ }
	}

	public class CreationId
	{
		public string ISWC { get; set; }
		public string OpusNumber { get; set; }
		public IList<string> ComposerCatalogNumbers { get; set; }
		public string ISRC { get; set; }
		public string ISMN { get; set; }
		public string ISAN { get; set; }
		public string VISAN { get; set; }
		public string ISBN { get; set; }
		public string ISSN { get; set; }
		public string SICI { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public CreationId(XElement element)
		{
			ISWC = element.Elements().Where(e => e.Name == "ISWC").Select(e => e.Value).SingleOrDefault();
			OpusNumber = element.Elements().Where(e => e.Name == "OpusNumber").Select(e => e.Value).SingleOrDefault();
			ComposerCatalogNumbers = element.Elements().Where(e => e.Name == "ComposerCatalogNumber").Select(e => e.Value).ToList();
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			ISMN = element.Elements().Where(e => e.Name == "ISMN").Select(e => e.Value).SingleOrDefault();
			ISAN = element.Elements().Where(e => e.Name == "ISAN").Select(e => e.Value).SingleOrDefault();
			VISAN = element.Elements().Where(e => e.Name == "VISAN").Select(e => e.Value).SingleOrDefault();
			ISBN = element.Elements().Where(e => e.Name == "ISBN").Select(e => e.Value).SingleOrDefault();
			ISSN = element.Elements().Where(e => e.Name == "ISSN").Select(e => e.Value).SingleOrDefault();
			SICI = element.Elements().Where(e => e.Name == "SICI").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public CreationId()
		{ }
	}

	public class Cue1
	{
		public string CueUseType { get; set; }
		public string CueThemeType { get; set; }
		public string CueVocalType { get; set; }
		public string IsDance { get; set; }
		public string CueVisualPerceptionType { get; set; }
		public string CueOrigin { get; set; }
		public IList<CueCreationReference> CueCreationReferences { get; set; }
		public string ReferencedCreationType { get; set; }
		public CreationId ReferencedCreationId { get; set; }
		public IList<Title> ReferencedCreationTitles { get; set; }
		public IList<ResourceContributor> ReferencedCreationContributors { get; set; }
		public string HasMusicalContent { get; set; }
		public string StartTime { get; set; }
		public string Duration { get; set; }
		public string EndTime { get; set; }

		public Cue1(XElement element)
		{
			CueUseType = element.Elements().Where(e => e.Name == "CueUseType").Select(e => e.Value).SingleOrDefault();
			CueThemeType = element.Elements().Where(e => e.Name == "CueThemeType").Select(e => e.Value).SingleOrDefault();
			CueVocalType = element.Elements().Where(e => e.Name == "CueVocalType").Select(e => e.Value).SingleOrDefault();
			IsDance = element.Elements().Where(e => e.Name == "IsDance").Select(e => e.Value).SingleOrDefault();
			CueVisualPerceptionType = element.Elements().Where(e => e.Name == "CueVisualPerceptionType").Select(e => e.Value).SingleOrDefault();
			CueOrigin = element.Elements().Where(e => e.Name == "CueOrigin").Select(e => e.Value).SingleOrDefault();
			CueCreationReferences = element.Elements().Where(e => e.Name == "CueCreationReference").Select(e => new CueCreationReference(e)).ToList();
			ReferencedCreationType = element.Elements().Where(e => e.Name == "ReferencedCreationType").Select(e => e.Value).SingleOrDefault();
			ReferencedCreationId = element.Elements().Where(e => e.Name == "ReferencedCreationId").Select(e => new CreationId(e)).SingleOrDefault();
			ReferencedCreationTitles = element.Elements().Where(e => e.Name == "ReferencedCreationTitle").Select(e => new Title(e)).ToList();
			ReferencedCreationContributors = element.Elements().Where(e => e.Name == "ReferencedCreationContributor").Select(e => new ResourceContributor(e)).ToList();
			HasMusicalContent = element.Elements().Where(e => e.Name == "HasMusicalContent").Select(e => e.Value).SingleOrDefault();
			StartTime = element.Elements().Where(e => e.Name == "StartTime").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			EndTime = element.Elements().Where(e => e.Name == "EndTime").Select(e => e.Value).SingleOrDefault();
		}

		public Cue1()
		{ }
	}

	public class CueCreationReference
	{
		public string CueWorkReference { get; set; }
		public string CueResourceReference { get; set; }

		public CueCreationReference(XElement element)
		{
			CueWorkReference = element.Elements().Where(e => e.Name == "CueWorkReference").Select(e => e.Value).SingleOrDefault();
			CueResourceReference = element.Elements().Where(e => e.Name == "CueResourceReference").Select(e => e.Value).SingleOrDefault();
		}

		public CueCreationReference()
		{ }
	}

	public class CueSheet1
	{
		public IList<string> CueSheetIds { get; set; }
		public string CueSheetReference { get; set; }
		public string CueSheetType { get; set; }
		public IList<Cue1> Cues { get; set; }

		public CueSheet1(XElement element)
		{
			CueSheetIds = element.Elements().Where(e => e.Name == "CueSheetId").Select(e => e.Value).ToList();
			CueSheetReference = element.Elements().Where(e => e.Name == "CueSheetReference").Select(e => e.Value).SingleOrDefault();
			CueSheetType = element.Elements().Where(e => e.Name == "CueSheetType").Select(e => e.Value).SingleOrDefault();
			Cues = element.Elements().Where(e => e.Name == "Cue").Select(e => new Cue1(e)).ToList();
		}

		public CueSheet1()
		{ }
	}

	public class CueSheetList1
	{
		public IList<CueSheet1> CueSheets { get; set; }

		public CueSheetList1(XElement element)
		{
			CueSheets = element.Elements().Where(e => e.Name == "CueSheet").Select(e => new CueSheet1(e)).ToList();
		}

		public CueSheetList1()
		{ }
	}

	public class DSP
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public string TradingName { get; set; }
		public IList<string> URLs { get; set; }
		public string TerritoryCode { get; set; }

		public DSP(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			TradingName = element.Elements().Where(e => e.Name == "TradingName").Select(e => e.Value).SingleOrDefault();
			URLs = element.Elements().Where(e => e.Name == "URL").Select(e => e.Value).ToList();
			TerritoryCode = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).SingleOrDefault();
		}

		public DSP()
		{ }
	}

	public class DurationByUseType
	{
		public string Duration { get; set; }
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }

		public DurationByUseType(XElement element)
		{
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
		}

		public DurationByUseType()
		{ }
	}

	public class ErnMessageInBatch
	{
		public string MessageType { get; set; }
		public string MessageId { get; set; }
		public string URL { get; set; }
		public IList<ReleaseId> IncludedReleaseIds { get; set; }
		public string DeliveryType { get; set; }
		public string ProductType { get; set; }
		public HashSum HashSum { get; set; }
		public string Signature { get; set; }

		public ErnMessageInBatch(XElement element)
		{
			MessageType = element.Elements().Where(e => e.Name == "MessageType").Select(e => e.Value).SingleOrDefault();
			MessageId = element.Elements().Where(e => e.Name == "MessageId").Select(e => e.Value).SingleOrDefault();
			URL = element.Elements().Where(e => e.Name == "URL").Select(e => e.Value).SingleOrDefault();
			IncludedReleaseIds = element.Elements().Where(e => e.Name == "IncludedReleaseId").Select(e => new ReleaseId(e)).ToList();
			DeliveryType = element.Elements().Where(e => e.Name == "DeliveryType").Select(e => e.Value).SingleOrDefault();
			ProductType = element.Elements().Where(e => e.Name == "ProductType").Select(e => e.Value).SingleOrDefault();
			HashSum = element.Elements().Where(e => e.Name == "HashSum").Select(e => new HashSum(e)).SingleOrDefault();
			Signature = element.Elements().Where(e => e.Name == "Signature").Select(e => e.Value).SingleOrDefault();
		}

		public ErnMessageInBatch()
		{ }
	}

	public class ExternalResourceLink
	{
		public IList<string> URLs { get; set; }
		public Period ValidityPeriod { get; set; }
		public string ExternalLink { get; set; }
		public IList<string> ExternallyLinkedResourceTypes { get; set; }
		public string FileFormat { get; set; }

		public ExternalResourceLink(XElement element)
		{
			URLs = element.Elements().Where(e => e.Name == "URL").Select(e => e.Value).ToList();
			ValidityPeriod = element.Elements().Where(e => e.Name == "ValidityPeriod").Select(e => new Period(e)).SingleOrDefault();
			ExternalLink = element.Elements().Where(e => e.Name == "ExternalLink").Select(e => e.Value).SingleOrDefault();
			ExternallyLinkedResourceTypes = element.Elements().Where(e => e.Name == "ExternallyLinkedResourceType").Select(e => e.Value).ToList();
			FileFormat = element.Elements().Where(e => e.Name == "FileFormat").Select(e => e.Value).SingleOrDefault();
		}

		public ExternalResourceLink()
		{ }
	}

	public class File
	{
		public string FileName { get; set; }
		public string FilePath { get; set; }
		public string URL { get; set; }
		public HashSum HashSum { get; set; }

		public File(XElement element)
		{
			FileName = element.Elements().Where(e => e.Name == "FileName").Select(e => e.Value).SingleOrDefault();
			FilePath = element.Elements().Where(e => e.Name == "FilePath").Select(e => e.Value).SingleOrDefault();
			URL = element.Elements().Where(e => e.Name == "URL").Select(e => e.Value).SingleOrDefault();
			HashSum = element.Elements().Where(e => e.Name == "HashSum").Select(e => new HashSum(e)).SingleOrDefault();
		}

		public File()
		{ }
	}

	public class Fingerprint
	{
		public string FingerprintProp { get; set; }
		public string FingerprintAlgorithmType { get; set; }
		public string FingerprintAlgorithmVersion { get; set; }
		public string FingerprintAlgorithmParameter { get; set; }

		public Fingerprint(XElement element)
		{
			FingerprintProp = element.Elements().Where(e => e.Name == "Fingerprint").Select(e => e.Value).SingleOrDefault();
			FingerprintAlgorithmType = element.Elements().Where(e => e.Name == "FingerprintAlgorithmType").Select(e => e.Value).SingleOrDefault();
			FingerprintAlgorithmVersion = element.Elements().Where(e => e.Name == "FingerprintAlgorithmVersion").Select(e => e.Value).SingleOrDefault();
			FingerprintAlgorithmParameter = element.Elements().Where(e => e.Name == "FingerprintAlgorithmParameter").Select(e => e.Value).SingleOrDefault();
		}

		public Fingerprint()
		{ }
	}

	public class FulfillmentDate
	{
		public string FulfillmentDateProp { get; set; }
		public IList<string> ResourceReleaseReferences { get; set; }

		public FulfillmentDate(XElement element)
		{
			FulfillmentDateProp = element.Elements().Where(e => e.Name == "FulfillmentDate").Select(e => e.Value).SingleOrDefault();
			ResourceReleaseReferences = element.Elements().Where(e => e.Name == "ResourceReleaseReference").Select(e => e.Value).ToList();
		}

		public FulfillmentDate()
		{ }
	}

	public class Genre
	{
		public string GenreText { get; set; }
		public string SubGenre { get; set; }

		public Genre(XElement element)
		{
			GenreText = element.Elements().Where(e => e.Name == "GenreText").Select(e => e.Value).SingleOrDefault();
			SubGenre = element.Elements().Where(e => e.Name == "SubGenre").Select(e => e.Value).SingleOrDefault();
		}

		public Genre()
		{ }
	}

	public class HashSum
	{
		public string HashSumProp { get; set; }
		public string HashSumAlgorithmType { get; set; }

		public HashSum(XElement element)
		{
			HashSumProp = element.Elements().Where(e => e.Name == "HashSum").Select(e => e.Value).SingleOrDefault();
			HashSumAlgorithmType = element.Elements().Where(e => e.Name == "HashSumAlgorithmType").Select(e => e.Value).SingleOrDefault();
		}

		public HashSum()
		{ }
	}

	public class HostSoundCarrier
	{
		public IList<ReleaseId> ReleaseIds { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<AdministratingRecordCompany> AdministratingRecordCompanys { get; set; }
		public string TrackNumber { get; set; }
		public string VolumeNumberInSet { get; set; }

		public HostSoundCarrier(XElement element)
		{
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			AdministratingRecordCompanys = element.Elements().Where(e => e.Name == "AdministratingRecordCompany").Select(e => new AdministratingRecordCompany(e)).ToList();
			TrackNumber = element.Elements().Where(e => e.Name == "TrackNumber").Select(e => e.Value).SingleOrDefault();
			VolumeNumberInSet = element.Elements().Where(e => e.Name == "VolumeNumberInSet").Select(e => e.Value).SingleOrDefault();
		}

		public HostSoundCarrier()
		{ }
	}

	public class ImageDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string Description { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }

		public ImageDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			Description = element.Elements().Where(e => e.Name == "Description").Select(e => e.Value).SingleOrDefault();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public ImageDetailsByTerritory1()
		{ }
	}

	public class ImageId
	{
		public IList<string> ProprietaryIds { get; set; }

		public ImageId(XElement element)
		{
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public ImageId()
		{ }
	}

	public class IndirectResourceContributor
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public IList<string> IndirectResourceContributorRoles { get; set; }

		public IndirectResourceContributor(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			IndirectResourceContributorRoles = element.Elements().Where(e => e.Name == "IndirectResourceContributorRole").Select(e => e.Value).ToList();
		}

		public IndirectResourceContributor()
		{ }
	}

	public class MessageAuditTrail
	{
		public IList<MessageAuditTrailEvent> MessageAuditTrailEvents { get; set; }

		public MessageAuditTrail(XElement element)
		{
			MessageAuditTrailEvents = element.Elements().Where(e => e.Name == "MessageAuditTrailEvent").Select(e => new MessageAuditTrailEvent(e)).ToList();
		}

		public MessageAuditTrail()
		{ }
	}

	public class MessageAuditTrailEvent
	{
		public MessagingParty MessagingPartyDescriptor { get; set; }
		public string DateTime { get; set; }

		public MessageAuditTrailEvent(XElement element)
		{
			MessagingPartyDescriptor = element.Elements().Where(e => e.Name == "MessagingPartyDescriptor").Select(e => new MessagingParty(e)).SingleOrDefault();
			DateTime = element.Elements().Where(e => e.Name == "DateTime").Select(e => e.Value).SingleOrDefault();
		}

		public MessageAuditTrailEvent()
		{ }
	}

	public class MessageHeader
	{
		public string MessageThreadId { get; set; }
		public string MessageId { get; set; }
		public string MessageFileName { get; set; }
		public MessagingParty MessageSender { get; set; }
		public MessagingParty SentOnBehalfOf { get; set; }
		public MessagingParty MessageRecipient { get; set; }
		public string MessageCreatedDateTime { get; set; }
		public MessageAuditTrail MessageAuditTrail { get; set; }
		public string Comment { get; set; }
		public string MessageControlType { get; set; }

		public MessageHeader(XElement element)
		{
			MessageThreadId = element.Elements().Where(e => e.Name == "MessageThreadId").Select(e => e.Value).SingleOrDefault();
			MessageId = element.Elements().Where(e => e.Name == "MessageId").Select(e => e.Value).SingleOrDefault();
			MessageFileName = element.Elements().Where(e => e.Name == "MessageFileName").Select(e => e.Value).SingleOrDefault();
			MessageSender = element.Elements().Where(e => e.Name == "MessageSender").Select(e => new MessagingParty(e)).SingleOrDefault();
			SentOnBehalfOf = element.Elements().Where(e => e.Name == "SentOnBehalfOf").Select(e => new MessagingParty(e)).SingleOrDefault();
			MessageRecipient = element.Elements().Where(e => e.Name == "MessageRecipient").Select(e => new MessagingParty(e)).SingleOrDefault();
			MessageCreatedDateTime = element.Elements().Where(e => e.Name == "MessageCreatedDateTime").Select(e => e.Value).SingleOrDefault();
			MessageAuditTrail = element.Elements().Where(e => e.Name == "MessageAuditTrail").Select(e => new MessageAuditTrail(e)).SingleOrDefault();
			Comment = element.Elements().Where(e => e.Name == "Comment").Select(e => e.Value).SingleOrDefault();
			MessageControlType = element.Elements().Where(e => e.Name == "MessageControlType").Select(e => e.Value).SingleOrDefault();
		}

		public MessageHeader()
		{ }
	}

	public class MessageNotificationPeriod
	{
		public string StartDate { get; set; }
		public string EndDate { get; set; }

		public MessageNotificationPeriod(XElement element)
		{
			StartDate = element.Elements().Where(e => e.Name == "StartDate").Select(e => e.Value).SingleOrDefault();
			EndDate = element.Elements().Where(e => e.Name == "EndDate").Select(e => e.Value).SingleOrDefault();
		}

		public MessageNotificationPeriod()
		{ }
	}

	public class MessagingParty
	{
		public string PartyId { get; set; }
		public PartyName PartyName { get; set; }
		public string TradingName { get; set; }

		public MessagingParty(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyName = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).SingleOrDefault();
			TradingName = element.Elements().Where(e => e.Name == "TradingName").Select(e => e.Value).SingleOrDefault();
		}

		public MessagingParty()
		{ }
	}

	public class MidiDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<CLine> CLines { get; set; }

		public MidiDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
		}

		public MidiDetailsByTerritory1()
		{ }
	}

	public class MidiId
	{
		public IList<string> ProprietaryIds { get; set; }

		public MidiId(XElement element)
		{
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public MidiId()
		{ }
	}

	public class MusicalWork
	{
		public IList<MusicalWorkId> MusicalWorkIds { get; set; }
		public string MusicalWorkReference { get; set; }
		public IList<ReferenceTitle> ReferenceTitles { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<MusicalWorkContributor> MusicalWorkContributors { get; set; }
		public IList<string> MusicalWorkTypes { get; set; }
		public IList<RightShare> RightShares { get; set; }
		public IList<MusicalWorkDetailsByTerritory> MusicalWorkDetailsByTerritorys { get; set; }

		public MusicalWork(XElement element)
		{
			MusicalWorkIds = element.Elements().Where(e => e.Name == "MusicalWorkId").Select(e => new MusicalWorkId(e)).ToList();
			MusicalWorkReference = element.Elements().Where(e => e.Name == "MusicalWorkReference").Select(e => e.Value).SingleOrDefault();
			ReferenceTitles = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			MusicalWorkContributors = element.Elements().Where(e => e.Name == "MusicalWorkContributor").Select(e => new MusicalWorkContributor(e)).ToList();
			MusicalWorkTypes = element.Elements().Where(e => e.Name == "MusicalWorkType").Select(e => e.Value).ToList();
			RightShares = element.Elements().Where(e => e.Name == "RightShare").Select(e => new RightShare(e)).ToList();
			MusicalWorkDetailsByTerritorys = element.Elements().Where(e => e.Name == "MusicalWorkDetailsByTerritory").Select(e => new MusicalWorkDetailsByTerritory(e)).ToList();
		}

		public MusicalWork()
		{ }
	}

	public class MusicalWorkContributor
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public IList<string> MusicalWorkContributorRoles { get; set; }
		public IList<SocietyAffiliation> SocietyAffiliations { get; set; }

		public MusicalWorkContributor(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			MusicalWorkContributorRoles = element.Elements().Where(e => e.Name == "MusicalWorkContributorRole").Select(e => e.Value).ToList();
			SocietyAffiliations = element.Elements().Where(e => e.Name == "SocietyAffiliation").Select(e => new SocietyAffiliation(e)).ToList();
		}

		public MusicalWorkContributor()
		{ }
	}

	public class MusicalWorkDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<MusicalWorkContributor> MusicalWorkContributors { get; set; }

		public MusicalWorkDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			MusicalWorkContributors = element.Elements().Where(e => e.Name == "MusicalWorkContributor").Select(e => new MusicalWorkContributor(e)).ToList();
		}

		public MusicalWorkDetailsByTerritory()
		{ }
	}

	public class MusicalWorkId
	{
		public string ISWC { get; set; }
		public string OpusNumber { get; set; }
		public IList<string> ComposerCatalogNumbers { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public MusicalWorkId(XElement element)
		{
			ISWC = element.Elements().Where(e => e.Name == "ISWC").Select(e => e.Value).SingleOrDefault();
			OpusNumber = element.Elements().Where(e => e.Name == "OpusNumber").Select(e => e.Value).SingleOrDefault();
			ComposerCatalogNumbers = element.Elements().Where(e => e.Name == "ComposerCatalogNumber").Select(e => e.Value).ToList();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public MusicalWorkId()
		{ }
	}

	public class NumberOfSubscribers
	{
		public string Quantity { get; set; }
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }

		public NumberOfSubscribers(XElement element)
		{
			Quantity = element.Elements().Where(e => e.Name == "Quantity").Select(e => e.Value).SingleOrDefault();
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
		}

		public NumberOfSubscribers()
		{ }
	}

	public class PLine
	{
		public string Year { get; set; }
		public string PLineCompany { get; set; }
		public string PLineText { get; set; }

		public PLine(XElement element)
		{
			Year = element.Elements().Where(e => e.Name == "Year").Select(e => e.Value).SingleOrDefault();
			PLineCompany = element.Elements().Where(e => e.Name == "PLineCompany").Select(e => e.Value).SingleOrDefault();
			PLineText = element.Elements().Where(e => e.Name == "PLineText").Select(e => e.Value).SingleOrDefault();
		}

		public PLine()
		{ }
	}

	public class PartyDescriptor
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }

		public PartyDescriptor(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
		}

		public PartyDescriptor()
		{ }
	}

	public class PartyName
	{
		public string FullName { get; set; }
		public string FullNameAsciiTranscribed { get; set; }
		public string FullNameIndexed { get; set; }
		public string NamesBeforeKeyName { get; set; }
		public string KeyName { get; set; }
		public string NamesAfterKeyName { get; set; }
		public string AbbreviatedName { get; set; }

		public PartyName(XElement element)
		{
			FullName = element.Elements().Where(e => e.Name == "FullName").Select(e => e.Value).SingleOrDefault();
			FullNameAsciiTranscribed = element.Elements().Where(e => e.Name == "FullNameAsciiTranscribed").Select(e => e.Value).SingleOrDefault();
			FullNameIndexed = element.Elements().Where(e => e.Name == "FullNameIndexed").Select(e => e.Value).SingleOrDefault();
			NamesBeforeKeyName = element.Elements().Where(e => e.Name == "NamesBeforeKeyName").Select(e => e.Value).SingleOrDefault();
			KeyName = element.Elements().Where(e => e.Name == "KeyName").Select(e => e.Value).SingleOrDefault();
			NamesAfterKeyName = element.Elements().Where(e => e.Name == "NamesAfterKeyName").Select(e => e.Value).SingleOrDefault();
			AbbreviatedName = element.Elements().Where(e => e.Name == "AbbreviatedName").Select(e => e.Value).SingleOrDefault();
		}

		public PartyName()
		{ }
	}

	public class Period
	{
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string StartDateTime { get; set; }
		public string EndDateTime { get; set; }

		public Period(XElement element)
		{
			StartDate = element.Elements().Where(e => e.Name == "StartDate").Select(e => e.Value).SingleOrDefault();
			EndDate = element.Elements().Where(e => e.Name == "EndDate").Select(e => e.Value).SingleOrDefault();
			StartDateTime = element.Elements().Where(e => e.Name == "StartDateTime").Select(e => e.Value).SingleOrDefault();
			EndDateTime = element.Elements().Where(e => e.Name == "EndDateTime").Select(e => e.Value).SingleOrDefault();
		}

		public Period()
		{ }
	}

	public class PriceInformation
	{
		public string Description { get; set; }
		public string PriceRangeType { get; set; }
		public string PriceType { get; set; }
		public string WholesalePricePerUnit { get; set; }
		public string BulkOrderWholesalePricePerUnit { get; set; }
		public string SuggestedRetailPrice { get; set; }

		public PriceInformation(XElement element)
		{
			Description = element.Elements().Where(e => e.Name == "Description").Select(e => e.Value).SingleOrDefault();
			PriceRangeType = element.Elements().Where(e => e.Name == "PriceRangeType").Select(e => e.Value).SingleOrDefault();
			PriceType = element.Elements().Where(e => e.Name == "PriceType").Select(e => e.Value).SingleOrDefault();
			WholesalePricePerUnit = element.Elements().Where(e => e.Name == "WholesalePricePerUnit").Select(e => e.Value).SingleOrDefault();
			BulkOrderWholesalePricePerUnit = element.Elements().Where(e => e.Name == "BulkOrderWholesalePricePerUnit").Select(e => e.Value).SingleOrDefault();
			SuggestedRetailPrice = element.Elements().Where(e => e.Name == "SuggestedRetailPrice").Select(e => e.Value).SingleOrDefault();
		}

		public PriceInformation()
		{ }
	}

	public class RecordCompanyMarketShareData
	{
		public IList<string> ReleaseTypes { get; set; }
		public string UnitsSoldTotal { get; set; }
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }

		public RecordCompanyMarketShareData(XElement element)
		{
			ReleaseTypes = element.Elements().Where(e => e.Name == "ReleaseType").Select(e => e.Value).ToList();
			UnitsSoldTotal = element.Elements().Where(e => e.Name == "UnitsSoldTotal").Select(e => e.Value).SingleOrDefault();
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
		}

		public RecordCompanyMarketShareData()
		{ }
	}

	public class ReferenceTitle
	{
		public string TitleText { get; set; }
		public string SubTitle { get; set; }

		public ReferenceTitle(XElement element)
		{
			TitleText = element.Elements().Where(e => e.Name == "TitleText").Select(e => e.Value).SingleOrDefault();
			SubTitle = element.Elements().Where(e => e.Name == "SubTitle").Select(e => e.Value).SingleOrDefault();
		}

		public ReferenceTitle()
		{ }
	}

	public class RelatedLicenseOrClaimId
	{
		public RightsAgreementId LicenseOrClaimId { get; set; }
		public string LicenseOrClaimUpdateReason { get; set; }

		public RelatedLicenseOrClaimId(XElement element)
		{
			LicenseOrClaimId = element.Elements().Where(e => e.Name == "LicenseOrClaimId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LicenseOrClaimUpdateReason = element.Elements().Where(e => e.Name == "LicenseOrClaimUpdateReason").Select(e => e.Value).SingleOrDefault();
		}

		public RelatedLicenseOrClaimId()
		{ }
	}

	public class RelatedLicenseOrClaimRequestId
	{
		public string LicenseOrClaimRequestId { get; set; }
		public string LicenseOrClaimRequestUpdateReason { get; set; }

		public RelatedLicenseOrClaimRequestId(XElement element)
		{
			LicenseOrClaimRequestId = element.Elements().Where(e => e.Name == "LicenseOrClaimRequestId").Select(e => e.Value).SingleOrDefault();
			LicenseOrClaimRequestUpdateReason = element.Elements().Where(e => e.Name == "LicenseOrClaimRequestUpdateReason").Select(e => e.Value).SingleOrDefault();
		}

		public RelatedLicenseOrClaimRequestId()
		{ }
	}

	public class RelatedRelease
	{
		public IList<ReleaseId> ReleaseIds { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public IList<ReleaseSummaryDetailsByTerritory> ReleaseSummaryDetailsByTerritorys { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public string ReleaseRelationshipType { get; set; }
		public string ReleaseDate { get; set; }
		public string OriginalReleaseDate { get; set; }

		public RelatedRelease(XElement element)
		{
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			ReleaseSummaryDetailsByTerritorys = element.Elements().Where(e => e.Name == "ReleaseSummaryDetailsByTerritory").Select(e => new ReleaseSummaryDetailsByTerritory(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			ReleaseRelationshipType = element.Elements().Where(e => e.Name == "ReleaseRelationshipType").Select(e => e.Value).SingleOrDefault();
			ReleaseDate = element.Elements().Where(e => e.Name == "ReleaseDate").Select(e => e.Value).SingleOrDefault();
			OriginalReleaseDate = element.Elements().Where(e => e.Name == "OriginalReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public RelatedRelease()
		{ }
	}

	public class ReleaseCollectionReferenceList
	{
		public string NumberOfCollections { get; set; }
		public IList<string> ReleaseCollectionReferences { get; set; }

		public ReleaseCollectionReferenceList(XElement element)
		{
			NumberOfCollections = element.Elements().Where(e => e.Name == "NumberOfCollections").Select(e => e.Value).SingleOrDefault();
			ReleaseCollectionReferences = element.Elements().Where(e => e.Name == "ReleaseCollectionReference").Select(e => e.Value).ToList();
		}

		public ReleaseCollectionReferenceList()
		{ }
	}

	public class ReleaseDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<string> DisplayArtistNames { get; set; }
		public IList<string> LabelNames { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public string IsMultiArtistCompilation { get; set; }
		public IList<AdministratingRecordCompany> AdministratingRecordCompanys { get; set; }
		public IList<string> ReleaseTypes { get; set; }
		public IList<RelatedRelease> RelatedReleases { get; set; }

		public ReleaseDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			DisplayArtistNames = element.Elements().Where(e => e.Name == "DisplayArtistName").Select(e => e.Value).ToList();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			IsMultiArtistCompilation = element.Elements().Where(e => e.Name == "IsMultiArtistCompilation").Select(e => e.Value).SingleOrDefault();
			AdministratingRecordCompanys = element.Elements().Where(e => e.Name == "AdministratingRecordCompany").Select(e => new AdministratingRecordCompany(e)).ToList();
			ReleaseTypes = element.Elements().Where(e => e.Name == "ReleaseType").Select(e => e.Value).ToList();
			RelatedReleases = element.Elements().Where(e => e.Name == "RelatedRelease").Select(e => new RelatedRelease(e)).ToList();
		}

		public ReleaseDetailsByTerritory1()
		{ }
	}

	public class ReleaseId
	{
		public string GRid { get; set; }
		public string ISRC { get; set; }
		public string ICPN { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public ReleaseId(XElement element)
		{
			GRid = element.Elements().Where(e => e.Name == "GRid").Select(e => e.Value).SingleOrDefault();
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			ICPN = element.Elements().Where(e => e.Name == "ICPN").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public ReleaseId()
		{ }
	}

	public class ReleaseResourceReferenceList
	{
		public IList<string> ReleaseResourceReferences { get; set; }

		public ReleaseResourceReferenceList(XElement element)
		{
			ReleaseResourceReferences = element.Elements().Where(e => e.Name == "ReleaseResourceReference").Select(e => e.Value).ToList();
		}

		public ReleaseResourceReferenceList()
		{ }
	}

	public class ReleaseSummary
	{
		public IList<ReleaseId> ReleaseIds { get; set; }
		public ReferenceTitle ReferenceTitle { get; set; }
		public IList<ReleaseSummaryDetailsByTerritory> ReleaseSummaryDetailsByTerritorys { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }

		public ReleaseSummary(XElement element)
		{
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			ReferenceTitle = element.Elements().Where(e => e.Name == "ReferenceTitle").Select(e => new ReferenceTitle(e)).SingleOrDefault();
			ReleaseSummaryDetailsByTerritorys = element.Elements().Where(e => e.Name == "ReleaseSummaryDetailsByTerritory").Select(e => new ReleaseSummaryDetailsByTerritory(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
		}

		public ReleaseSummary()
		{ }
	}

	public class ReleaseSummaryDetailsByTerritory
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<string> DisplayArtistNames { get; set; }
		public IList<string> LabelNames { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }

		public ReleaseSummaryDetailsByTerritory(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			DisplayArtistNames = element.Elements().Where(e => e.Name == "DisplayArtistName").Select(e => e.Value).ToList();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
		}

		public ReleaseSummaryDetailsByTerritory()
		{ }
	}

	public class ResourceContainedResourceReference
	{
		public string ResourceContainedResourceReferenceProp { get; set; }
		public string DurationUsed { get; set; }
		public string StartPoint { get; set; }
		public string Purpose { get; set; }

		public ResourceContainedResourceReference(XElement element)
		{
			ResourceContainedResourceReferenceProp = element.Elements().Where(e => e.Name == "ResourceContainedResourceReference").Select(e => e.Value).SingleOrDefault();
			DurationUsed = element.Elements().Where(e => e.Name == "DurationUsed").Select(e => e.Value).SingleOrDefault();
			StartPoint = element.Elements().Where(e => e.Name == "StartPoint").Select(e => e.Value).SingleOrDefault();
			Purpose = element.Elements().Where(e => e.Name == "Purpose").Select(e => e.Value).SingleOrDefault();
		}

		public ResourceContainedResourceReference()
		{ }
	}

	public class ResourceContainedResourceReferenceList
	{
		public IList<ResourceContainedResourceReference> ResourceContainedResourceReferences { get; set; }

		public ResourceContainedResourceReferenceList(XElement element)
		{
			ResourceContainedResourceReferences = element.Elements().Where(e => e.Name == "ResourceContainedResourceReference").Select(e => new ResourceContainedResourceReference(e)).ToList();
		}

		public ResourceContainedResourceReferenceList()
		{ }
	}

	public class ResourceContributor
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public IList<string> ResourceContributorRoles { get; set; }

		public ResourceContributor(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			ResourceContributorRoles = element.Elements().Where(e => e.Name == "ResourceContributorRole").Select(e => e.Value).ToList();
		}

		public ResourceContributor()
		{ }
	}

	public class ResourceGroupResourceReferenceList
	{
		public IList<string> ResourceGroupResourceReferences { get; set; }

		public ResourceGroupResourceReferenceList(XElement element)
		{
			ResourceGroupResourceReferences = element.Elements().Where(e => e.Name == "ResourceGroupResourceReference").Select(e => e.Value).ToList();
		}

		public ResourceGroupResourceReferenceList()
		{ }
	}

	public class ResourceId
	{
		public string ISRC { get; set; }
		public string ISMN { get; set; }
		public string ISAN { get; set; }
		public string VISAN { get; set; }
		public string ISBN { get; set; }
		public string ISSN { get; set; }
		public string SICI { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public ResourceId(XElement element)
		{
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			ISMN = element.Elements().Where(e => e.Name == "ISMN").Select(e => e.Value).SingleOrDefault();
			ISAN = element.Elements().Where(e => e.Name == "ISAN").Select(e => e.Value).SingleOrDefault();
			VISAN = element.Elements().Where(e => e.Name == "VISAN").Select(e => e.Value).SingleOrDefault();
			ISBN = element.Elements().Where(e => e.Name == "ISBN").Select(e => e.Value).SingleOrDefault();
			ISSN = element.Elements().Where(e => e.Name == "ISSN").Select(e => e.Value).SingleOrDefault();
			SICI = element.Elements().Where(e => e.Name == "SICI").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public ResourceId()
		{ }
	}

	public class ResourceMusicalWorkReference
	{
		public string SequenceNumber { get; set; }
		public string DurationUsed { get; set; }
		public string IsFragment { get; set; }
		public string ResourceMusicalWorkReferenceProp { get; set; }

		public ResourceMusicalWorkReference(XElement element)
		{
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			DurationUsed = element.Elements().Where(e => e.Name == "DurationUsed").Select(e => e.Value).SingleOrDefault();
			IsFragment = element.Elements().Where(e => e.Name == "IsFragment").Select(e => e.Value).SingleOrDefault();
			ResourceMusicalWorkReferenceProp = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReference").Select(e => e.Value).SingleOrDefault();
		}

		public ResourceMusicalWorkReference()
		{ }
	}

	public class ResourceMusicalWorkReferenceList
	{
		public IList<ResourceMusicalWorkReference> ResourceMusicalWorkReferences { get; set; }

		public ResourceMusicalWorkReferenceList(XElement element)
		{
			ResourceMusicalWorkReferences = element.Elements().Where(e => e.Name == "ResourceMusicalWorkReference").Select(e => new ResourceMusicalWorkReference(e)).ToList();
		}

		public ResourceMusicalWorkReferenceList()
		{ }
	}

	public class RightShare
	{
		public RightsAgreementId RightShareId { get; set; }
		public string RightShareReference { get; set; }
		public RightShareCreationReferenceList RightShareCreationReferenceList { get; set; }
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<string> RightsTypes { get; set; }
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }
		public IList<string> CommercialModelTypes { get; set; }
		public IList<string> MusicalWorkRightsClaimTypes { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public Period ValidityPeriod { get; set; }
		public string PercentageUnknown { get; set; }
		public string PercentageRate { get; set; }
		public string TariffReference { get; set; }
		public string LicenseStatus { get; set; }
		public string HasFirstLicenseRefusal { get; set; }

		public RightShare(XElement element)
		{
			RightShareId = element.Elements().Where(e => e.Name == "RightShareId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			RightShareReference = element.Elements().Where(e => e.Name == "RightShareReference").Select(e => e.Value).SingleOrDefault();
			RightShareCreationReferenceList = element.Elements().Where(e => e.Name == "RightShareCreationReferenceList").Select(e => new RightShareCreationReferenceList(e)).SingleOrDefault();
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			RightsTypes = element.Elements().Where(e => e.Name == "RightsType").Select(e => e.Value).ToList();
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
			CommercialModelTypes = element.Elements().Where(e => e.Name == "CommercialModelType").Select(e => e.Value).ToList();
			MusicalWorkRightsClaimTypes = element.Elements().Where(e => e.Name == "MusicalWorkRightsClaimType").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			ValidityPeriod = element.Elements().Where(e => e.Name == "ValidityPeriod").Select(e => new Period(e)).SingleOrDefault();
			PercentageUnknown = element.Elements().Where(e => e.Name == "PercentageUnknown").Select(e => e.Value).SingleOrDefault();
			PercentageRate = element.Elements().Where(e => e.Name == "PercentageRate").Select(e => e.Value).SingleOrDefault();
			TariffReference = element.Elements().Where(e => e.Name == "TariffReference").Select(e => e.Value).SingleOrDefault();
			LicenseStatus = element.Elements().Where(e => e.Name == "LicenseStatus").Select(e => e.Value).SingleOrDefault();
			HasFirstLicenseRefusal = element.Elements().Where(e => e.Name == "HasFirstLicenseRefusal").Select(e => e.Value).SingleOrDefault();
		}

		public RightShare()
		{ }
	}

	public class RightShareCreationReferenceList
	{
		public IList<string> RightShareWorkReferences { get; set; }
		public IList<string> RightShareResourceReferences { get; set; }
		public IList<string> RightShareReleaseReferences { get; set; }

		public RightShareCreationReferenceList(XElement element)
		{
			RightShareWorkReferences = element.Elements().Where(e => e.Name == "RightShareWorkReference").Select(e => e.Value).ToList();
			RightShareResourceReferences = element.Elements().Where(e => e.Name == "RightShareResourceReference").Select(e => e.Value).ToList();
			RightShareReleaseReferences = element.Elements().Where(e => e.Name == "RightShareReleaseReference").Select(e => e.Value).ToList();
		}

		public RightShareCreationReferenceList()
		{ }
	}

	public class RightsAgreementId
	{
		public IList<string> MWLIs { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public RightsAgreementId(XElement element)
		{
			MWLIs = element.Elements().Where(e => e.Name == "MWLI").Select(e => e.Value).ToList();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public RightsAgreementId()
		{ }
	}

	public class RightsController
	{
		public string PartyId { get; set; }
		public IList<PartyName> PartyNames { get; set; }
		public IList<string> RightsControllerRoles { get; set; }
		public string RightShareUnknown { get; set; }
		public string RightSharePercentage { get; set; }

		public RightsController(XElement element)
		{
			PartyId = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).SingleOrDefault();
			PartyNames = element.Elements().Where(e => e.Name == "PartyName").Select(e => new PartyName(e)).ToList();
			RightsControllerRoles = element.Elements().Where(e => e.Name == "RightsControllerRole").Select(e => e.Value).ToList();
			RightShareUnknown = element.Elements().Where(e => e.Name == "RightShareUnknown").Select(e => e.Value).SingleOrDefault();
			RightSharePercentage = element.Elements().Where(e => e.Name == "RightSharePercentage").Select(e => e.Value).SingleOrDefault();
		}

		public RightsController()
		{ }
	}

	public class SalesReportingProxyReleaseId
	{
		public ReleaseId ReleaseId { get; set; }
		public string Reason { get; set; }
		public string ReasonType { get; set; }

		public SalesReportingProxyReleaseId(XElement element)
		{
			ReleaseId = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).SingleOrDefault();
			Reason = element.Elements().Where(e => e.Name == "Reason").Select(e => e.Value).SingleOrDefault();
			ReasonType = element.Elements().Where(e => e.Name == "ReasonType").Select(e => e.Value).SingleOrDefault();
		}

		public SalesReportingProxyReleaseId()
		{ }
	}

	public class SheetMusicDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }

		public SheetMusicDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public SheetMusicDetailsByTerritory1()
		{ }
	}

	public class SheetMusicId
	{
		public string ISMN { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public SheetMusicId(XElement element)
		{
			ISMN = element.Elements().Where(e => e.Name == "ISMN").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public SheetMusicId()
		{ }
	}

	public class SocietyAffiliation
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public PartyDescriptor MusicRightsSociety { get; set; }

		public SocietyAffiliation(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			MusicRightsSociety = element.Elements().Where(e => e.Name == "MusicRightsSociety").Select(e => new PartyDescriptor(e)).SingleOrDefault();
		}

		public SocietyAffiliation()
		{ }
	}

	public class SoftwareDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }

		public SoftwareDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public SoftwareDetailsByTerritory1()
		{ }
	}

	public class SoftwareId
	{
		public IList<string> ProprietaryIds { get; set; }

		public SoftwareId(XElement element)
		{
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public SoftwareId()
		{ }
	}

	public class SoundRecordingCollectionReference
	{
		public string SequenceNumber { get; set; }
		public string SoundRecordingCollectionReferenceProp { get; set; }
		public string StartTime { get; set; }
		public string Duration { get; set; }
		public string EndTime { get; set; }
		public string ReleaseResourceType { get; set; }

		public SoundRecordingCollectionReference(XElement element)
		{
			SequenceNumber = element.Elements().Where(e => e.Name == "SequenceNumber").Select(e => e.Value).SingleOrDefault();
			SoundRecordingCollectionReferenceProp = element.Elements().Where(e => e.Name == "SoundRecordingCollectionReference").Select(e => e.Value).SingleOrDefault();
			StartTime = element.Elements().Where(e => e.Name == "StartTime").Select(e => e.Value).SingleOrDefault();
			Duration = element.Elements().Where(e => e.Name == "Duration").Select(e => e.Value).SingleOrDefault();
			EndTime = element.Elements().Where(e => e.Name == "EndTime").Select(e => e.Value).SingleOrDefault();
			ReleaseResourceType = element.Elements().Where(e => e.Name == "ReleaseResourceType").Select(e => e.Value).SingleOrDefault();
		}

		public SoundRecordingCollectionReference()
		{ }
	}

	public class SoundRecordingCollectionReferenceList
	{
		public string NumberOfCollections { get; set; }
		public IList<SoundRecordingCollectionReference> SoundRecordingCollectionReferences { get; set; }

		public SoundRecordingCollectionReferenceList(XElement element)
		{
			NumberOfCollections = element.Elements().Where(e => e.Name == "NumberOfCollections").Select(e => e.Value).SingleOrDefault();
			SoundRecordingCollectionReferences = element.Elements().Where(e => e.Name == "SoundRecordingCollectionReference").Select(e => new SoundRecordingCollectionReference(e)).ToList();
		}

		public SoundRecordingCollectionReferenceList()
		{ }
	}

	public class SoundRecordingDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<PLine> PLines { get; set; }

		public SoundRecordingDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
		}

		public SoundRecordingDetailsByTerritory1()
		{ }
	}

	public class SoundRecordingId
	{
		public string ISRC { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public SoundRecordingId(XElement element)
		{
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public SoundRecordingId()
		{ }
	}

	public class TaxRate
	{
		public string Rate { get; set; }
		public IList<string> TaxTypes { get; set; }
		public IList<string> TaxScopes { get; set; }

		public TaxRate(XElement element)
		{
			Rate = element.Elements().Where(e => e.Name == "Rate").Select(e => e.Value).SingleOrDefault();
			TaxTypes = element.Elements().Where(e => e.Name == "TaxType").Select(e => e.Value).ToList();
			TaxScopes = element.Elements().Where(e => e.Name == "TaxScope").Select(e => e.Value).ToList();
		}

		public TaxRate()
		{ }
	}

	public class TechnicalInstantiation
	{
		public string DrmEnforcementType { get; set; }
		public string VideoDefinitionType { get; set; }
		public string CodingType { get; set; }
		public string BitRate { get; set; }

		public TechnicalInstantiation(XElement element)
		{
			DrmEnforcementType = element.Elements().Where(e => e.Name == "DrmEnforcementType").Select(e => e.Value).SingleOrDefault();
			VideoDefinitionType = element.Elements().Where(e => e.Name == "VideoDefinitionType").Select(e => e.Value).SingleOrDefault();
			CodingType = element.Elements().Where(e => e.Name == "CodingType").Select(e => e.Value).SingleOrDefault();
			BitRate = element.Elements().Where(e => e.Name == "BitRate").Select(e => e.Value).SingleOrDefault();
		}

		public TechnicalInstantiation()
		{ }
	}

	public class TextDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<CLine> CLines { get; set; }
		public string CourtesyLine { get; set; }
		public string OriginalResourceReleaseDate { get; set; }

		public TextDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			CourtesyLine = element.Elements().Where(e => e.Name == "CourtesyLine").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public TextDetailsByTerritory1()
		{ }
	}

	public class TextId
	{
		public string ISBN { get; set; }
		public string ISSN { get; set; }
		public string SICI { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public TextId(XElement element)
		{
			ISBN = element.Elements().Where(e => e.Name == "ISBN").Select(e => e.Value).SingleOrDefault();
			ISSN = element.Elements().Where(e => e.Name == "ISSN").Select(e => e.Value).SingleOrDefault();
			SICI = element.Elements().Where(e => e.Name == "SICI").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public TextId()
		{ }
	}

	public class Title
	{
		public string TitleText { get; set; }
		public IList<string> SubTitles { get; set; }

		public Title(XElement element)
		{
			TitleText = element.Elements().Where(e => e.Name == "TitleText").Select(e => e.Value).SingleOrDefault();
			SubTitles = element.Elements().Where(e => e.Name == "SubTitle").Select(e => e.Value).ToList();
		}

		public Title()
		{ }
	}

	public class TotalRoyaltyAmount
	{
		public IList<string> ReleaseTypes { get; set; }
		public IList<string> RightsTypes { get; set; }
		public string RoyaltyAmount { get; set; }

		public TotalRoyaltyAmount(XElement element)
		{
			ReleaseTypes = element.Elements().Where(e => e.Name == "ReleaseType").Select(e => e.Value).ToList();
			RightsTypes = element.Elements().Where(e => e.Name == "RightsType").Select(e => e.Value).ToList();
			RoyaltyAmount = element.Elements().Where(e => e.Name == "RoyaltyAmount").Select(e => e.Value).SingleOrDefault();
		}

		public TotalRoyaltyAmount()
		{ }
	}

	public class Usage
	{
		public IList<string> UseTypes { get; set; }
		public IList<string> UserInterfaceTypes { get; set; }
		public IList<string> DistributionChannelTypes { get; set; }
		public IList<string> CarrierTypes { get; set; }
		public TechnicalInstantiation TechnicalInstantiation { get; set; }
		public string NumberOfUsages { get; set; }

		public Usage(XElement element)
		{
			UseTypes = element.Elements().Where(e => e.Name == "UseType").Select(e => e.Value).ToList();
			UserInterfaceTypes = element.Elements().Where(e => e.Name == "UserInterfaceType").Select(e => e.Value).ToList();
			DistributionChannelTypes = element.Elements().Where(e => e.Name == "DistributionChannelType").Select(e => e.Value).ToList();
			CarrierTypes = element.Elements().Where(e => e.Name == "CarrierType").Select(e => e.Value).ToList();
			TechnicalInstantiation = element.Elements().Where(e => e.Name == "TechnicalInstantiation").Select(e => new TechnicalInstantiation(e)).SingleOrDefault();
			NumberOfUsages = element.Elements().Where(e => e.Name == "NumberOfUsages").Select(e => e.Value).SingleOrDefault();
		}

		public Usage()
		{ }
	}

	public class UserDefinedResourceDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public IList<string> UserDefinedValues { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }
		public string OriginalResourceReleaseDate { get; set; }

		public UserDefinedResourceDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			UserDefinedValues = element.Elements().Where(e => e.Name == "UserDefinedValue").Select(e => e.Value).ToList();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
		}

		public UserDefinedResourceDetailsByTerritory1()
		{ }
	}

	public class UserDefinedResourceId
	{
		public IList<string> ProprietaryIds { get; set; }

		public UserDefinedResourceId(XElement element)
		{
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public UserDefinedResourceId()
		{ }
	}

	public class VideoCueSheetReference
	{
		public string VideoCueSheetReferenceProp { get; set; }

		public VideoCueSheetReference(XElement element)
		{
			VideoCueSheetReferenceProp = element.Elements().Where(e => e.Name == "VideoCueSheetReference").Select(e => e.Value).SingleOrDefault();
		}

		public VideoCueSheetReference()
		{ }
	}

	public class VideoCueSheetReferenceList
	{
		public IList<string> VideoCueSheetReferences { get; set; }

		public VideoCueSheetReferenceList(XElement element)
		{
			VideoCueSheetReferences = element.Elements().Where(e => e.Name == "VideoCueSheetReference").Select(e => e.Value).ToList();
		}

		public VideoCueSheetReferenceList()
		{ }
	}

	public class VideoDetailsByTerritory1
	{
		public IList<string> TerritoryCodes { get; set; }
		public IList<string> ExcludedTerritoryCodes { get; set; }
		public IList<Title> Titles { get; set; }
		public IList<Artist> DisplayArtists { get; set; }
		public IList<ResourceContributor> ResourceContributors { get; set; }
		public IList<IndirectResourceContributor> IndirectResourceContributors { get; set; }
		public RightsAgreementId RightsAgreementId { get; set; }
		public IList<string> LabelNames { get; set; }
		public IList<RightsController> RightsControllers { get; set; }
		public string RemasteredDate { get; set; }
		public string OriginalResourceReleaseDate { get; set; }
		public IList<PLine> PLines { get; set; }
		public IList<CLine> CLines { get; set; }

		public VideoDetailsByTerritory1(XElement element)
		{
			TerritoryCodes = element.Elements().Where(e => e.Name == "TerritoryCode").Select(e => e.Value).ToList();
			ExcludedTerritoryCodes = element.Elements().Where(e => e.Name == "ExcludedTerritoryCode").Select(e => e.Value).ToList();
			Titles = element.Elements().Where(e => e.Name == "Title").Select(e => new Title(e)).ToList();
			DisplayArtists = element.Elements().Where(e => e.Name == "DisplayArtist").Select(e => new Artist(e)).ToList();
			ResourceContributors = element.Elements().Where(e => e.Name == "ResourceContributor").Select(e => new ResourceContributor(e)).ToList();
			IndirectResourceContributors = element.Elements().Where(e => e.Name == "IndirectResourceContributor").Select(e => new IndirectResourceContributor(e)).ToList();
			RightsAgreementId = element.Elements().Where(e => e.Name == "RightsAgreementId").Select(e => new RightsAgreementId(e)).SingleOrDefault();
			LabelNames = element.Elements().Where(e => e.Name == "LabelName").Select(e => e.Value).ToList();
			RightsControllers = element.Elements().Where(e => e.Name == "RightsController").Select(e => new RightsController(e)).ToList();
			RemasteredDate = element.Elements().Where(e => e.Name == "RemasteredDate").Select(e => e.Value).SingleOrDefault();
			OriginalResourceReleaseDate = element.Elements().Where(e => e.Name == "OriginalResourceReleaseDate").Select(e => e.Value).SingleOrDefault();
			PLines = element.Elements().Where(e => e.Name == "PLine").Select(e => new PLine(e)).ToList();
			CLines = element.Elements().Where(e => e.Name == "CLine").Select(e => new CLine(e)).ToList();
		}

		public VideoDetailsByTerritory1()
		{ }
	}

	public class VideoId
	{
		public string ISRC { get; set; }
		public string ISAN { get; set; }
		public string VISAN { get; set; }
		public string CatalogNumber { get; set; }
		public IList<string> ProprietaryIds { get; set; }

		public VideoId(XElement element)
		{
			ISRC = element.Elements().Where(e => e.Name == "ISRC").Select(e => e.Value).SingleOrDefault();
			ISAN = element.Elements().Where(e => e.Name == "ISAN").Select(e => e.Value).SingleOrDefault();
			VISAN = element.Elements().Where(e => e.Name == "VISAN").Select(e => e.Value).SingleOrDefault();
			CatalogNumber = element.Elements().Where(e => e.Name == "CatalogNumber").Select(e => e.Value).SingleOrDefault();
			ProprietaryIds = element.Elements().Where(e => e.Name == "ProprietaryId").Select(e => e.Value).ToList();
		}

		public VideoId()
		{ }
	}

	public class WebPage
	{
		public IList<string> PartyIds { get; set; }
		public IList<ReleaseId> ReleaseIds { get; set; }
		public string PageName { get; set; }
		public string URL { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

		public WebPage(XElement element)
		{
			PartyIds = element.Elements().Where(e => e.Name == "PartyId").Select(e => e.Value).ToList();
			ReleaseIds = element.Elements().Where(e => e.Name == "ReleaseId").Select(e => new ReleaseId(e)).ToList();
			PageName = element.Elements().Where(e => e.Name == "PageName").Select(e => e.Value).SingleOrDefault();
			URL = element.Elements().Where(e => e.Name == "URL").Select(e => e.Value).SingleOrDefault();
			UserName = element.Elements().Where(e => e.Name == "UserName").Select(e => e.Value).SingleOrDefault();
			Password = element.Elements().Where(e => e.Name == "Password").Select(e => e.Value).SingleOrDefault();
		}

		public WebPage()
		{ }
	}

	public class WorkList
	{
		public IList<MusicalWork> MusicalWorks { get; set; }

		public WorkList(XElement element)
		{
			MusicalWorks = element.Elements().Where(e => e.Name == "MusicalWork").Select(e => new MusicalWork(e)).ToList();
		}

		public WorkList()
		{ }
	}

}