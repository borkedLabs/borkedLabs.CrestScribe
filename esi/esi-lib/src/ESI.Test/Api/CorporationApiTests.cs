/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ESI.Client;
using ESI.Api;
using ESI.Model;

namespace ESI.Test
{
    /// <summary>
    ///  Class for testing CorporationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CorporationApiTests
    {
        private CorporationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CorporationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CorporationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CorporationApi
            //Assert.IsInstanceOfType(typeof(CorporationApi), instance, "instance is a CorporationApi");
        }

        
        /// <summary>
        /// Test GetCorporationsCorporationId
        /// </summary>
        [Test]
        public void GetCorporationsCorporationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? corporationId = null;
            //string datasource = null;
            //var response = instance.GetCorporationsCorporationId(corporationId, datasource);
            //Assert.IsInstanceOf<GetCorporationsCorporationIdOk> (response, "response is GetCorporationsCorporationIdOk");
        }
        
        /// <summary>
        /// Test GetCorporationsCorporationIdAlliancehistory
        /// </summary>
        [Test]
        public void GetCorporationsCorporationIdAlliancehistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? corporationId = null;
            //string datasource = null;
            //var response = instance.GetCorporationsCorporationIdAlliancehistory(corporationId, datasource);
            //Assert.IsInstanceOf<List<GetCorporationsCorporationIdAlliancehistory200Ok>> (response, "response is List<GetCorporationsCorporationIdAlliancehistory200Ok>");
        }
        
        /// <summary>
        /// Test GetCorporationsCorporationIdIcons
        /// </summary>
        [Test]
        public void GetCorporationsCorporationIdIconsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? corporationId = null;
            //string datasource = null;
            //var response = instance.GetCorporationsCorporationIdIcons(corporationId, datasource);
            //Assert.IsInstanceOf<GetCorporationsCorporationIdIconsOk> (response, "response is GetCorporationsCorporationIdIconsOk");
        }
        
        /// <summary>
        /// Test GetCorporationsCorporationIdMembers
        /// </summary>
        [Test]
        public void GetCorporationsCorporationIdMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? corporationId = null;
            //string datasource = null;
            //var response = instance.GetCorporationsCorporationIdMembers(corporationId, datasource);
            //Assert.IsInstanceOf<List<GetCorporationsCorporationIdMembers200Ok>> (response, "response is List<GetCorporationsCorporationIdMembers200Ok>");
        }
        
        /// <summary>
        /// Test GetCorporationsCorporationIdRoles
        /// </summary>
        [Test]
        public void GetCorporationsCorporationIdRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? corporationId = null;
            //string datasource = null;
            //var response = instance.GetCorporationsCorporationIdRoles(corporationId, datasource);
            //Assert.IsInstanceOf<List<GetCorporationsCorporationIdRoles200Ok>> (response, "response is List<GetCorporationsCorporationIdRoles200Ok>");
        }
        
        /// <summary>
        /// Test GetCorporationsNames
        /// </summary>
        [Test]
        public void GetCorporationsNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<long?> corporationIds = null;
            //string datasource = null;
            //var response = instance.GetCorporationsNames(corporationIds, datasource);
            //Assert.IsInstanceOf<List<GetCorporationsNames200Ok>> (response, "response is List<GetCorporationsNames200Ok>");
        }
        
    }

}