// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace CastleTests.GenInterfaces
{

#pragma warning disable 0693 // Type parameter 'type parameter' has the same name as the type parameter from outer type 'type'

	public interface ISimpleGenericSameName<T>
	{
		void Method<T>();
	}

	public class SimpleGenericSameName<T> : ISimpleGenericSameName<T>
	{
		public virtual void Method<T>()
		{
			
		}
	}
#pragma warning restore
}