# Org.OpenAPITools.Api.WorkflowsApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportEvent**](WorkflowsApi.md#reportevent) | **POST** /workflows/v1/events/report |  |

<a id="reportevent"></a>
# **ReportEvent**
> ReportEventResponse1 ReportEvent (WorkflowsEsbConfigResolverWorkflowsV1EventsReportPostReportEventRequestBody workflowsEsbConfigResolverWorkflowsV1EventsReportPostReportEventRequestBody)



Reports an event and activates account workflows with the specified trigger key. Only the app that created a trigger can report events for it. This means other apps can't report events for your triggers, and you can't report events for another app's triggers.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowsEsbConfigResolverWorkflowsV1EventsReportPostReportEventRequestBody** | [**WorkflowsEsbConfigResolverWorkflowsV1EventsReportPostReportEventRequestBody**](WorkflowsEsbConfigResolverWorkflowsV1EventsReportPostReportEventRequestBody.md) |  |  |

### Return type

[**ReportEventResponse1**](ReportEventResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **400** | Bad Request - Invalid input or parameters  Possible error codes: &#x60;REQUIRED_PROPERTY&#x60; |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;SCHEMA_VALIDATION_FAILED&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

