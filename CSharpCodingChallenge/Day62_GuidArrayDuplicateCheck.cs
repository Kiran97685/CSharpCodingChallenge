using System;

namespace CSharpCodingChallenge
{
    internal class Day62_GuidArrayDuplicateCheck
    {
        public void FindDuplicateGuids()
        {
            Guid[] ids =
            {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid()
            };

            // Intentionally creating duplicates
            ids[2] = ids[0];
            ids[3] = ids[1];

            Console.WriteLine("Duplicate GUIDs:");

            for (int i = 0; i < ids.Length; i++)
            {
                int count = 1;

                if (ids[i] == Guid.Empty)
                    continue;

                for (int j = i + 1; j < ids.Length; j++)
                {
                    if (ids[i] == ids[j])
                    {
                        count++;
                        ids[j] = Guid.Empty; // mark as visited
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(ids[i] + " → Count: " + count);
                }
            }
        }
    }
}
