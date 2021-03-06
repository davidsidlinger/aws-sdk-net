/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.Route53.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListResourceRecordSetsResult Unmarshaller
     /// </summary>
    internal class ListResourceRecordSetsResultUnmarshaller : IUnmarshaller<ListResourceRecordSetsResult, XmlUnmarshallerContext> 
    {
        public ListResourceRecordSetsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListResourceRecordSetsResult listResourceRecordSetsResult = new ListResourceRecordSetsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ResourceRecordSets/ResourceRecordSet", targetDepth))
                    {
                        listResourceRecordSetsResult.ResourceRecordSets.Add(ResourceRecordSetUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        listResourceRecordSetsResult.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextRecordName", targetDepth))
                    {
                        listResourceRecordSetsResult.NextRecordName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextRecordType", targetDepth))
                    {
                        listResourceRecordSetsResult.NextRecordType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextRecordIdentifier", targetDepth))
                    {
                        listResourceRecordSetsResult.NextRecordIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        listResourceRecordSetsResult.MaxItems = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listResourceRecordSetsResult;
                }
            }
                        


            return listResourceRecordSetsResult;
        }

        private static ListResourceRecordSetsResultUnmarshaller instance;

        public static ListResourceRecordSetsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListResourceRecordSetsResultUnmarshaller();

            return instance;
        }
    }
}
    
