# TimeRewindingFunctionalityPart01

[![Made With Unity](https://img.shields.io/badge/Made%20With-Unity-57b9d3.svg?style=popout&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAC%2FVBMVEUAAABVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVWVlZVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVWVlZXV1dYWFhZWVlaWlpbW1tcXFxdXV1eXl5fX19gYGBhYWFjY2NkZGRlZWVmZmZoaGhsbGxtbW1vb29xcXFzc3N1dXV4eHh7e3t8fHx%2Ff3%2BAgICBgYGCgoKDg4OFhYWGhoaJiYmKioqLi4uMjIyNjY2SkpKTk5OUlJSVlZWYmJiampqbm5ucnJydnZ2enp6fn5%2BgoKChoaGjo6OkpKSlpaWnp6eoqKiqqqqrq6utra2vr6%2Bzs7O1tbW3t7e5ubm7u7u8vLy9vb2%2Fv7%2FAwMDBwcHDw8PExMTFxcXHx8fIyMjJycnLy8vMzMzNzc3Ozs7Pz8%2FR0dHS0tLT09PU1NTV1dXW1tbX19fY2NjZ2dna2trb29vd3d3f39%2Fh4eHj4%2BPl5eXn5%2Bfp6enq6urt7e3v7%2B%2Fx8fHy8vL09PT19fX29vb39%2Ff4%2BPj5%2Bfn6%2Bvr7%2B%2Fv8%2FPz9%2Ff3%2B%2Fv7%2F%2F%2F%2BVA1MGAAAAinRSTlMAAQIEBQYICQoLDA0ODxAREhMUFhcYGxweHyEiJCUmJygpKy0uLzAxMjM0NTg8Q0hMUlVXXV5gZmpsbXF3eHp8foSEhYaIiY%2BWl5mbn6Smqa2ur7Gys7S2t7q8vr%2FAxcfIys3Oz9HS09TV1tfY2drb3N3e3%2BLj5Obo6err7O7w8fP09vf5%2Bvv8%2Ff6WvJ5aAAACw0lEQVR42nWTdzxVYRjH3%2BYtZBTR0NJSSlN779LSktIyEhJ1UyEtdD249rhGKklpWaUSUVlNJKPISJtS9nXv8%2Bk93YvP5%2BL713nO93fOeZ%2FnfQ%2FpmF59xy3at02hE6syeamuLfCueq3ryI5ZZmp3Di6kfPvTGGrfznab6wBevOsv65Ah3kFDMqAJdzLKG1FMEWeeZMA8tE4shUiBjV3bnMyGY%2Bzj8Bax6W%2Fl8%2FAHyBB5oH%2BrV9oDMbExKZWFqVEhADwBYhlitqN6i%2B9uCIVCvvCNrwfYrtwM5Yjp4Yg1MFPspc24uYj4DozmqBApiGrC6gDvRuRf3iLyAwwhi%2FoXsLsfrfQ8K1CQDO4fUPD4%2FP9V9jaBIuqz3YxYtJrqGIv420MfkplXTqR35CxpGLEArBTk5ORUdnnwEW%2BdkraLbMDvgWsIGWLuynw%2FE8DSyNjY2AJolee8hKwI%2FIUVvtpE6TCUUV%2BZGC%2FiXhofa4Ns5Ik6lAhuO8oSXbdSlCSVaU%2FGJqkcZhGiy%2Fsk6YXJMIUQKXZCLmjRzT%2FCpWPBH3ExIqKfNWONP1uWjIZi%2Fo2zPQkZxXb9SBNPAE7bUk5yihFfOy8kywOqsNRzNW1zpJUfM4YMMFAbpKo61iCAthlxos%2FRa%2FX4M2gtoSgfcqUJ4Ssw7EKr6U53aVPcHZCEmO%2BiSRiGWcF7RHzqqi9Fq70%2BX1GQCO4FKEgB8YEYftArnybSQVdLjSg6RTdjlb93LfLDthMxiqZQQBNZ4GjP1t4JXxDTwhDrYDZpYaA53E9MSK%2FLjwv240IwDdMHcjnjSStDt5obmEAeM5Kc5CuZyHDTTJm0wZKVkbG4KBplQy0ywCbRGtuYBDGl1fUopoSzgEjAWmwNvhGJOZXI8NBhQvtfS37E%2FP3A9Ql59Bnx0hnSMaxpOtb2HJcIr%2FWkU3pozFilpzOYXv0DNPPQRf7daI0AAAAASUVORK5CYII%3D)](https://unity3d.com)

[![Maintenance](https://img.shields.io/badge/Maintained%3F-no-red.svg)](https://bitbucket.org/lbesson/ansi-colors) [![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://matthewongamedesign.wordpress.com/)

Prince-of-Persia-Style Time-Rewinding Example for a Tuts+ Article in Unity3d, part 1 of 2
