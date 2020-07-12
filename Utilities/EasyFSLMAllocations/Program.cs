using System;
using System.Collections.Generic;

/// <summary>
/// To simplify tne operatoin and trust in the subnetting in Trustlane VSLM addresses are effectively FSLM subnets for the larger allocations. This may benefit older/outdated hardware and simplify the international routing between the "islands". Of course beyond the FSLM specification, a VSLM sub-netting may occur.
/// One logical way to make this "cloud agnostic" is to take one FSLM subnet and define it as "Azure" and the other as "Amazon". Then the routing tables are really simple and could be hard coded in the Trustlane Intranet.
///
/// This technology is easily adaptable to IPv6 and has many more possibilities in the V2 version of the data routing, workflow, anonomization, queueing, and processing engines.
/// </summary>
namespace EasyFSLMAllocations
{
    class QueueData
    {
        public ulong QueueSize { get; set; }
        public ulong QueueLength { get; set; }

        /// <summary>
        /// A REST style "scope" parameter that defines the source queue
        /// </summary>
        /// <example>
        /// /purpose/origin/optionalAdditionalIdentifiers(confidential, ODATA filters, etc)
        /// </example>
        public string QueueOrigin { get; set; }

        /// <summary>
        /// A REST style "scope" parameter that defines the desitnation endpoint
        /// </summary>
        /// <example>
        /// /purpose/destination/optionalAdditionalIdentifiers(confidential, ODATA filters, etc)
        /// </example>
        public string QueueDestination { get; set; }
    }

    // GET https://management.azure.com/subscriptions/291bba3f-e0a5-47bc-a099-3bdcb2a50a05/locations?api-version=2020-01-01
    class RegionDefinition
    {
        public string DisplayName { get; set; }

        /// <summary>
        /// The latitude is used to "draw a bouncing line" among all the nodes around the world in a GUI format
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// The longitiude is used to "draw a bouncing line" among all the nodes around the world in a GUI format
        /// </summary>
        public string Longitiude { get; set; }

        public string RegionShortName { get; set; }

        public double DataEgressCost { get; set; }
        public double DataIngressCost { get; set; }
    }

    class RegionFeatures
    {
        public override string ToString()
        {
            return RegionDefinition.DisplayName;
        }

        public RegionDefinition RegionDefinition { get; set; }

        public bool HasStorage { get; set; }
        public bool HasWebAssembly { get; set; }
        public bool HasSMTP { get; set; }
        public bool HasVIOP { get; set; }
        public bool HasVPN { get; set; }

        public double Availability { get; set; }
        public string Performance { get; set; }
        public List<QueueData> QueueData { get; set; }

        /// <summary>
        /// Watch out for sites that approach the maxium budget load (network, IO etc)
        /// </summary>
        public double BudgetThreshold { get; set; }
    }

    class SubnetAllocation
    {
        public override string ToString()
        {
            return this.Subnet1.Region + " {" + this.Subnet0.FSLMBegin + " " + this.Subnet1.FSLMBegin + " " + this.Subnet2.FSLMBegin + " " + this.Subnet3.FSLMBegin + "}";
        }
        public SubnetStrategy Subnet0 { get; set; }
        public SubnetStrategy Subnet1 { get; set; }
        public SubnetStrategy Subnet2 { get; set; }
        public SubnetStrategy Subnet3 { get; set; }

        public bool IsActive { get; set; }
    }
    class SubnetStrategy
    {
        public string DisplayName { get; set; }
        public string Region { get; set; }
        public string Designation { get; set; }
        public string NetworkBytes { get; set; }
        public int FSLMBegin { get; set; }
        public int FSLMEnd { get; set; }
        public int HostBegin { get; set; }
        public int HostEnd { get; set; }

        public bool IsActive { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            int value = 240;
            string binary = Convert.ToString(value, 2);

            System.Collections.Generic.List<SubnetStrategy> subnetList = new System.Collections.Generic.List<SubnetStrategy>();
            System.Collections.Generic.List<SubnetAllocation> subnetAllocations = new System.Collections.Generic.List<SubnetAllocation>();

            string[] regionsArray = new string[] { "Africa", "Asia Pacific", "Australia", "Azure Government", "Brazil", "Canada", "China", "Europe", "France", "Germany", "India", "Japan", "Korea", "Norway", "Switzerland", "United Arab Emirates", "United Kingdom", "United States", "Health Research 1", "Impact Investing Research 1", "Research Maslow 1", "Research Maslow 2", "Research Maslow 3", "Research Maslow 4", "Research Maslow 5" };

            int ii = 0;
            int unallocated = 0;

            for (int i = 0; i <= 256; i = i + 4)
            {
                if (i == 0 || i == 1)
                    continue;

                if (i == 253 || i == 254 || i == 255 || i == 256)
                    break;

                if (ii < regionsArray.Length)
                {
                    string region0 = regionsArray[ii] + " " + (ii + 0);
                    var temp0 = new SubnetStrategy() { DisplayName = "", Region = region0, Designation = "SubnetZero", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 0 };

                    string region1 = regionsArray[ii] + " " + (ii + 1);
                    var temp1 = new SubnetStrategy() { DisplayName = "", Region = region1, Designation = "Zone1", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 1 };

                    string region2 = regionsArray[ii] + " " + (ii + 2);
                    var temp2 = new SubnetStrategy() { DisplayName = "", Region = region2, Designation = "Zone2", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 2 };

                    string region3 = regionsArray[ii] + " " + (ii + 3);
                    var temp3 = new SubnetStrategy() { DisplayName = "", Region = region3, Designation = "AllOnesSubnet", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 3 };

                    subnetAllocations.Add(new SubnetAllocation()
                    {
                        Subnet0 = temp0,
                        Subnet1 = temp1,
                        Subnet2 = temp2,
                        Subnet3 = temp3,
                    });

                    ii = ii + 1;

                    continue;
                }
                else
                {
                    string region0 = "Unallocated" + (unallocated + 0);
                    var temp0 = new SubnetStrategy() { DisplayName = "", Region = region0, Designation = "SubnetZero", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 0 };

                    string region1 = "Unallocated" + (unallocated + 1);
                    var temp1 = new SubnetStrategy() { DisplayName = "", Region = region1, Designation = "Zone1", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 1 };

                    string region2 = "Unallocated" + (unallocated + 2);
                    var temp2 = new SubnetStrategy() { DisplayName = "", Region = region2, Designation = "Zone2", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 2 };

                    string region3 = "Unallocated" + (unallocated + 3);
                    var temp3 = new SubnetStrategy() { DisplayName = "", Region = region3, Designation = "AllOnesSubnet", NetworkBytes = Convert.ToString(i, 2), FSLMBegin = i + 3 };

                    subnetAllocations.Add(new SubnetAllocation()
                    {
                        Subnet0 = temp0,
                        Subnet1 = temp1,
                        Subnet2 = temp2,
                        Subnet3 = temp3,

                        IsActive = false
                    }); ;

                    unallocated = unallocated + 1;

                    continue;
                }
            }

            foreach (var subnet in subnetAllocations)
            {
                Console.WriteLine(subnet.ToString());
            }

            Console.Read();

            //todo: console Azure authentication to create subnets and routes as needed to peers in the configuration.
            // Create storage, website, api, and B2C application value per instance/locatoin
            // Github publish to each lane with a different B2C directory for {dev,test,prod } and governance {} , in addition to each region 
        }
    }
}