# SSIS_Analyzer
MS SQL SSIS database tools for packages, jobs, and more.


**Old SSIS Viewer**

  This is basically the SSIS Viewer with a really crappy UI. This is my first VB.Net application, and this was my first UI on it, so give me a break :D   Really though, it will probably die very soon. I think I've only kept it for sentimental reasons. It works, its just that the SSIS Viewer looks SO much better... not that my UI work could probably use some touching up!

**SSIS Viewer**

  This is a MS SSIS project viewer. It is currently limited to viewing the Source/Destination components of each DataFlow, the Execute SQL Tasks, and the Project/Package/DataFlowTask structure of each project that is opened. It shows a few relavent details of each item, but was originally made with the following intents:
- simplify the viewing of any and all SQL within a package
- match columns between Source & Destination components
- show the Database & tables used to pull/push data in a component
    
**Job Viewer**

  This is a SSIS Job viewer... yes, there is a better(?) viewer built in to MS SQL Server Management, but this was built to overcome the lack of connection between the ExecutionID passed back to a Job from SQL Server Agent and what information that ExecutionID is tied to. This shows the schedule, commands, proxy, and other information, but it will mainly be used for getting the last ExecutionID or a specific ExecutionID and returning relavent information from ... i don't remember now... i think i'm getting them all confused.
  
**Job Dashboard (WIP)**

  This is hasn't been implemented or even hinted at on GitHub yet. Basically, I will be creating a dashboard that (given certain priorities) will sort all the jobs on the server and give relavent info (completion time, completion status, umm a few more). For example:
- Show all the disabled jobs which were recently (within the last 2 weeks?) disabled. Prioritize them by next run date being closest to now. (This will help find jobs that were supposed to be temporarily disabled)
- Show all the enabled jobs where the last run completion status was failure. Prioritize by next run date.
  
Another idea is to have a history of the completion times and show these in a graph to help see spikes and identify other failures. (Like when a job that normally completes in an hour completes with success in a few seconds or vice-versa)
