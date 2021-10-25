namespace test_grafana.Controllers
{
    public class QueryPayload
    {
        public string[] adhocFilters { get; set; }
        public string app { get; set; }
        public int? dashboardId { get; set; }
        public string interval { get; set; }
        public int intervalMs { get; set; }

        public int maxDataPoints { get; set; }

        public int panelId { get; set; }
         public Range range { get; set; }

        public class Range
        {
            public string from { get; set; }
            public string to { get; set; }

            public Raw raw { get; set; }

            public class Raw
            {
                public string from { get; set; }
                public string tp { get; set; }
            }

            public Rangeraw rangeraw { get; set; }

            public class Rangeraw
            {
                public string from { get; set; }
                public string to { get; set; }
            }

            public string requestId {get; set;}

            public ScopedVars scopedVars { get; set; }
            public long startTime { get; set; }


            public string timeInfo { get; set; }
            public string timezone { get; set; }

            public class ScopedVars
            {
                public Interval __interval { get; set; }
                 public Interval_ms __interval_ms { get; set; }

                public class Interval
                {
                    public string text { get; set; }
                    public string value { get; set; }
                }

                public class Interval_ms
                {
                    public string text { get; set; }
                    public string value { get; set; }
                }
            }

            public Targets targets { get; set; }

            public class Targets
            {
                public class Zero
                {
                    public string data { get; set; }
                    public string datasource { get; set; }

                    public string queryType { get; set; }

                    public string refId { get; set; }

                    public string target { get; set; }


                    public string type { get; set; }


                }

                public Zero O {get;set;}

            }
        }
    }

}