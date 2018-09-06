/* 
 * Manage Contractors APIs
 *
 * This API supports all services required to manage Employees on HR system
 *
 * OpenAPI spec version: 0.1
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ContractorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContractorsApiTests
    {
        private ContractorsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContractorsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContractorsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContractorsApi
            //Assert.IsInstanceOfType(typeof(ContractorsApi), instance, "instance is a ContractorsApi");
        }

        
        /// <summary>
        /// Test ContractorsEmployeeIDDelete
        /// </summary>
        [Test]
        public void ContractorsEmployeeIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? employeeID = null;
            //instance.ContractorsEmployeeIDDelete(employeeID);
            
        }
        
        /// <summary>
        /// Test ContractorsEmployeeIDGet
        /// </summary>
        [Test]
        public void ContractorsEmployeeIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? employeeID = null;
            //var response = instance.ContractorsEmployeeIDGet(employeeID);
            //Assert.IsInstanceOf<Employee> (response, "response is Employee");
        }
        
        /// <summary>
        /// Test ContractorsGet
        /// </summary>
        [Test]
        public void ContractorsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ContractorsGet();
            
        }
        
        /// <summary>
        /// Test ContractorsPost
        /// </summary>
        [Test]
        public void ContractorsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Employee employee = null;
            //instance.ContractorsPost(employee);
            
        }
        
    }

}