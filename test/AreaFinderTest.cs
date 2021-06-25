using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;

namespace AreaSearch.Test
{
 public class AreaFinderTest {
	private static string DATASET_CSV = "dataset.csv";
	private static string EXPECTED_DATASET_CSV = "expected_dataset.csv";

	private static List<DataPoint> dataset;
	private static List<DataPoint> expectedResult;
	private static Rectangle rect;

	[SetUp]
	public static void LoadData()
    {
		dataset = DataSet.ReadDataPoints(DATASET_CSV);
		expectedResult = DataSet.ReadDataPoints(EXPECTED_DATASET_CSV);
		rect = new Rectangle(-0.1f, -0.1f, 0.1f, 0.1f);
	}

	[Test]
	public void TestBruteForceAreaFinder() {
		loadDataset(BruteForceAreaFinder.constructFrom(new Collection<DataPoint>(dataset)));
	}

	private void loadDataset(AreaFinder finder){
		PointCollector collector = new PointCollector();
		finder.findPointsInside(rect, collector);
		List<DataPoint> actualResult = collector.getConsumedPoints();
		Assert.IsTrue(areIdentical(actualResult, expectedResult));
	}

	private bool areIdentical(List<DataPoint> actualResults, List<DataPoint> expectedResults) {
		return   actualResults.Count == expectedResults.Count
				&& actualResults.Intersect(expectedResults).Count() == actualResults.Count
				&& expectedResults.Intersect(actualResults).Count() == expectedResults.Count;
	}

	private class PointCollector : PointConsumer {

		List <DataPoint> results = new List<DataPoint>();

		public void consumePoint(DataPoint point) {
			//todo : implement
		}

		public List<DataPoint> getConsumedPoints(){
			return  results;
		}
	}

}
}

