/*
 * Copyright(c) Live2D Inc. All rights reserved.
 * 
 * Use of this source code is governed by the Live2D Open Software license
 * that can be found at http://live2d.com/eula/live2d-open-software-license-agreement_en.html.
 */


using UnityEngine;


namespace Live2D.Cubism.Framework.Raycasting
{
    /// <summary>
    /// Allows raycasting against <see cref="Core.CubismDrawable"/>s.
    /// </summary>

	// 就是简单的脚本挂载，进行标记
    public sealed class CubismRaycastable : MonoBehaviour
    {
        /// <summary>
        /// The precision.
        /// </summary>

		// 就是指定枚举是BoundingBox，还是Triangles
		// Triangles是没有实现？
        public CubismRaycastablePrecision Precision;
    }
}
