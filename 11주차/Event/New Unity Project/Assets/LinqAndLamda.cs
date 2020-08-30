using System.Linq; // 린큐 / 링크 린크
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinqAndLamda : MonoBehaviour
{
    void 설명()
    {
        //LINQ -> SQL문을 이용하여 데이터를 검색/정렬 시킬 때 사용합니다.
        List<Character> targets = new List<Character>();

        targets.Where(t => t.hp >= 100).ToList(); /// hp가 100 이상인 애들
        targets.Select(t => t.hp).ToList(); // 애들의 hp 를 가지고 list로 생성
        if (targets.Any(t => t.hp > 100)) // 한명이라도 hp가 100 이상인 얘가 있는 지?
        {
            //코드
        }

        if (targets.All(t => t.hp > 100)) // 모두 hp가 100 이상인지?
        {
            //코드
        }

        // 나랑 가장 가까이 있는 녀석
        Character closestTarget =
            targets.OrderBy(t => Vector3.Distance(this.transform.position, t.transform.position))
            .First();

        // 나랑 가장 멀리 있는 녀석
        Character longestTarget =
            targets.OrderBy(t => Vector3.Distance(this.transform.position, t.transform.position))
            .Last();

        targets = targets.OrderBy(t => t.hp).ToList(); // 오름 차순 정렬
        targets = targets.OrderByDescending(t => t.hp).ToList(); // 내림 차순 정렬

        Character firstFullHPChar = targets.First(t => t.hp > 100); // 해당 조건을 만족하는 첫번째 요소, 만족하는 요소가 없으면 에러
        Character lastFullHPChar = targets.Last(t => t.hp > 100); // 해당 조건을 만족하는 마지막 요소, 만족하는 요소가 없으면 에러

        firstFullHPChar = targets.FirstOrDefault(t => t.hp > 100); // 해당 조건을 만족하는 첫번째 요소, 만족하는 요소가 없으면 기본값
        firstFullHPChar = targets.LastOrDefault(t => t.hp > 100); // 해당 조건을 만족하는 마지막 요소, 만족하는 요소가 없으면 기본값

        double avgHP = targets.Average(t => t.hp); /// hp들의 평균값
        int sumHP = targets.Sum(t => t.hp); // hp들의 합산값

        targets = targets.Distinct().ToList(); // 중복 요소 제거
        targets.Max(t => t.hp); // 최대
        targets.Min(t => t.hp); // 최대
    }
}
